namespace L4
{
    public interface IFunction
    {
        double CalcValue(double[] x);
    }

    public interface IConstarint
    {
        public double RightHandValue { get; }

        public NLPSolver.ConstraintType ConstrainType { get; }

        double CalcValue(double[] x);
    }

    public class IFunctionWrapper : IFunction
    {
        Func<double[], double> F { get; init; }

        internal IFunctionWrapper(Func<double[], double> fn)
        {
            F = fn;
        }

        public double CalcValue(double[] x) => F(x);

        public static IFunction Make(Func<double[], double> fn) => new IFunctionWrapper(fn);
    }
}
