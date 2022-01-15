namespace L4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_runButton = new System.Windows.Forms.Button();
            this.m_listView = new System.Windows.Forms.ListView();
            this.m_x0ColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.m_resultColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.m_resultValueColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.m_plotView = new OxyPlot.WindowsForms.PlotView();
            this.m_stochasticHillClimbingButton = new System.Windows.Forms.RadioButton();
            this.m_sqpMethodButton = new System.Windows.Forms.RadioButton();
            this.m_methodPanel = new System.Windows.Forms.Panel();
            this.m_nLabel = new System.Windows.Forms.Label();
            this.m_nTextBox = new System.Windows.Forms.TextBox();
            this.m_updateButton = new System.Windows.Forms.Button();
            this.m_methodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_runButton
            // 
            this.m_runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_runButton.Location = new System.Drawing.Point(1246, 927);
            this.m_runButton.Name = "m_runButton";
            this.m_runButton.Size = new System.Drawing.Size(120, 29);
            this.m_runButton.TabIndex = 0;
            this.m_runButton.Text = "Run";
            this.m_runButton.UseVisualStyleBackColor = true;
            this.m_runButton.Click += new System.EventHandler(this.OnRun);
            // 
            // m_listView
            // 
            this.m_listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_x0ColumnHeader,
            this.m_resultColumnHeader,
            this.m_resultValueColumnHeader});
            this.m_listView.Location = new System.Drawing.Point(12, 12);
            this.m_listView.Name = "m_listView";
            this.m_listView.Size = new System.Drawing.Size(241, 944);
            this.m_listView.TabIndex = 1;
            this.m_listView.UseCompatibleStateImageBehavior = false;
            this.m_listView.View = System.Windows.Forms.View.Details;
            // 
            // m_x0ColumnHeader
            // 
            this.m_x0ColumnHeader.Text = "X0";
            // 
            // m_resultColumnHeader
            // 
            this.m_resultColumnHeader.Text = "X";
            // 
            // m_resultValueColumnHeader
            // 
            this.m_resultValueColumnHeader.Text = "Max(F)";
            // 
            // m_plotView
            // 
            this.m_plotView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_plotView.BackColor = System.Drawing.Color.White;
            this.m_plotView.Location = new System.Drawing.Point(259, 12);
            this.m_plotView.Name = "m_plotView";
            this.m_plotView.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.m_plotView.Size = new System.Drawing.Size(1107, 909);
            this.m_plotView.TabIndex = 2;
            this.m_plotView.Text = "PlotView";
            this.m_plotView.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.m_plotView.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.m_plotView.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // m_stochasticHillClimbingButton
            // 
            this.m_stochasticHillClimbingButton.AutoSize = true;
            this.m_stochasticHillClimbingButton.Checked = true;
            this.m_stochasticHillClimbingButton.Location = new System.Drawing.Point(12, 2);
            this.m_stochasticHillClimbingButton.Name = "m_stochasticHillClimbingButton";
            this.m_stochasticHillClimbingButton.Size = new System.Drawing.Size(188, 24);
            this.m_stochasticHillClimbingButton.TabIndex = 3;
            this.m_stochasticHillClimbingButton.TabStop = true;
            this.m_stochasticHillClimbingButton.Text = "Stochastic Hill Climbing";
            this.m_stochasticHillClimbingButton.UseVisualStyleBackColor = true;
            // 
            // m_sqpMethodButton
            // 
            this.m_sqpMethodButton.AutoSize = true;
            this.m_sqpMethodButton.Location = new System.Drawing.Point(207, 2);
            this.m_sqpMethodButton.Name = "m_sqpMethodButton";
            this.m_sqpMethodButton.Size = new System.Drawing.Size(57, 24);
            this.m_sqpMethodButton.TabIndex = 3;
            this.m_sqpMethodButton.Text = "SQP";
            this.m_sqpMethodButton.UseVisualStyleBackColor = true;
            // 
            // m_methodPanel
            // 
            this.m_methodPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_methodPanel.AutoSize = true;
            this.m_methodPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_methodPanel.Controls.Add(this.m_stochasticHillClimbingButton);
            this.m_methodPanel.Controls.Add(this.m_sqpMethodButton);
            this.m_methodPanel.Location = new System.Drawing.Point(419, 930);
            this.m_methodPanel.Name = "m_methodPanel";
            this.m_methodPanel.Size = new System.Drawing.Size(267, 29);
            this.m_methodPanel.TabIndex = 4;
            // 
            // m_nLabel
            // 
            this.m_nLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_nLabel.AutoSize = true;
            this.m_nLabel.Location = new System.Drawing.Point(259, 933);
            this.m_nLabel.Name = "m_nLabel";
            this.m_nLabel.Size = new System.Drawing.Size(23, 20);
            this.m_nLabel.TabIndex = 5;
            this.m_nLabel.Text = "N:";
            // 
            // m_nTextBox
            // 
            this.m_nTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_nTextBox.Location = new System.Drawing.Point(288, 930);
            this.m_nTextBox.Name = "m_nTextBox";
            this.m_nTextBox.Size = new System.Drawing.Size(125, 27);
            this.m_nTextBox.TabIndex = 6;
            this.m_nTextBox.Text = "10";
            this.m_nTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnNValidating);
            // 
            // m_updateButton
            // 
            this.m_updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_updateButton.Location = new System.Drawing.Point(699, 929);
            this.m_updateButton.Name = "m_updateButton";
            this.m_updateButton.Size = new System.Drawing.Size(94, 29);
            this.m_updateButton.TabIndex = 7;
            this.m_updateButton.Text = "Update";
            this.m_updateButton.UseVisualStyleBackColor = true;
            this.m_updateButton.Click += new System.EventHandler(this.OnUpdate);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 968);
            this.Controls.Add(this.m_updateButton);
            this.Controls.Add(this.m_nTextBox);
            this.Controls.Add(this.m_nLabel);
            this.Controls.Add(this.m_methodPanel);
            this.Controls.Add(this.m_plotView);
            this.Controls.Add(this.m_listView);
            this.Controls.Add(this.m_runButton);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Nonlinear Programming Problem";
            this.m_methodPanel.ResumeLayout(false);
            this.m_methodPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button m_runButton;
        private ListView m_listView;
        private OxyPlot.WindowsForms.PlotView m_plotView;
        private ColumnHeader m_x0ColumnHeader;
        private ColumnHeader m_resultColumnHeader;
        private ColumnHeader m_resultValueColumnHeader;
        private RadioButton m_stochasticHillClimbingButton;
        private RadioButton m_sqpMethodButton;
        private Panel m_methodPanel;
        private Label m_nLabel;
        private TextBox m_nTextBox;
        private Button m_updateButton;
    }
}