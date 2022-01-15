using CenterSpace.NMath.Core;

namespace L4
{
    public class NLPSolver
    {
        public enum ConstraintType
        {
            Upper,  // <= constraint
            Lower,  // >= constraint
            Equal   // == constraint
        }

        public enum BoundType
        {
            Upper,
            Lower,
        }

        public enum Method
        {
            StochasticHillClimbing,
            SQP,
        }

        public struct Result
        {
            public bool Succeeded;
            public double[] X;
            public double Value;

            public static Result Empty => new Result() { Succeeded = false, X = new double[] { }, Value = 0 };
        }

        NonlinearProgrammingProblem NLPProblem { get; init; }

        DoubleVector X0 { get; init; }

        public NLPSolver(IFunction func, double[] x0)
        {
            if (x0?.Length == 0)
            {
                throw new InvalidArgumentException(nameof(x0));
            }

            X0 = new DoubleVector(x0);
            NLPProblem = new NonlinearProgrammingProblem(X0.Length, new Func<DoubleVector, double>(x => func.CalcValue(x.ToArray())));
        }

        public void AddBound(BoundType type, int xIndex, double bound)
        {
            if (xIndex < 0 || xIndex >= NLPProblem.NumVariables)
            {
                throw new InvalidArgumentException(nameof(xIndex));
            }

            switch (type)
            {
                case BoundType.Upper:
                    NLPProblem.AddUpperBound(xIndex, bound);
                    break;
                case BoundType.Lower:
                    NLPProblem.AddLowerBound(xIndex, bound);
                    break;
                default:
                    throw new InvalidArgumentException(nameof(type));
            }
        }

        public void AddConstraint(IConstarint constraint)
        {
            if (constraint == null)
            {
                throw new InvalidArgumentException(nameof(constraint));
            }

            switch (constraint.ConstrainType)
            {
                case ConstraintType.Upper:
                    NLPProblem.AddUpperBoundConstraint(X0.Length, new Func<DoubleVector, double>(x => constraint.CalcValue(x.ToArray())), constraint.RightHandValue);
                    break;
                case ConstraintType.Lower:
                    NLPProblem.AddLowerBoundConstraint(X0.Length, new Func<DoubleVector, double>(x => constraint.CalcValue(x.ToArray())), constraint.RightHandValue);
                    break;
                case ConstraintType.Equal:
                    NLPProblem.AddEqualityConstraint(X0.Length, new Func<DoubleVector, double>(x => constraint.CalcValue(x.ToArray())), constraint.RightHandValue);
                    break;
                default:
                    throw new InvalidArgumentException(nameof(constraint.ConstrainType));
            }
        }

        public Result Solve(bool minimaze = true, Method method = Method.StochasticHillClimbing)
        {
            var res = Result.Empty;

            switch (method)
            {
                case Method.StochasticHillClimbing:
                    {
                        var solver = new StochasticHillClimbingSolver();
                        var solverParams = new StochasticHillClimbingParameters()
                        {
                            TimeLimitMilliSeconds = 10000,
                            Presolve = true,
                            Minimize = minimaze,
                        };

                        solver.Solve(NLPProblem, X0, solverParams);

                        res.Succeeded = solver.Result == ConstrainedOptimizer.SolveResult.Optimal || 
                                        solver.Result == ConstrainedOptimizer.SolveResult.LocalOptimal;
                        if (res.Succeeded)
                        {
                            res.X = solver.OptimalX.ToArray();
                            res.Value = solver.OptimalObjectiveFunctionValue;
                        }
                    }
                    break;

                case Method.SQP:
                    {
                        if (!minimaze)
                        {
                            throw new ArgumentException("SQP method can't maximaze objective function", nameof(minimaze));
                        }

                        var solver = new ActiveSetLineSearchSQP();

                        res.Succeeded = solver.Solve(NLPProblem, X0);
                        if (res.Succeeded)
                        {
                            res.X = solver.OptimalX.ToArray();
                            res.Value = solver.OptimalObjectiveFunctionValue;
                        }
                    }
                    break;

                default:
                    throw new InvalidArgumentException(nameof(method));
            }

            return res;
        }
    }
}
