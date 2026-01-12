namespace Assinment_3
{
    partial class LoanCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label SummaryLabel;
        private System.Windows.Forms.RadioButton OneYearRadioButton;
        private System.Windows.Forms.RadioButton ThreeYearsRadioButton;
        private System.Windows.Forms.RadioButton FiveYearsRadioButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button BackButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanCalculatorForm));
            SummaryLabel = new Label();
            OneYearRadioButton = new RadioButton();
            ThreeYearsRadioButton = new RadioButton();
            FiveYearsRadioButton = new RadioButton();
            SubmitButton = new Button();
            BackButton = new Button();
            LoanGroupbox = new GroupBox();
            Noloanradiobutton = new RadioButton();
            oneyeartooltip = new ToolTip(components);
            fiveyeartooltip = new ToolTip(components);
            threeyeartoolTip = new ToolTip(components);
            NoloantoolTip = new ToolTip(components);
            Submittooltip = new ToolTip(components);
            Backtooltip = new ToolTip(components);
            LoanGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // SummaryLabel
            // 
            SummaryLabel.BackColor = Color.Gold;
            SummaryLabel.Location = new Point(20, 19);
            SummaryLabel.Name = "SummaryLabel";
            SummaryLabel.Size = new Size(500, 402);
            SummaryLabel.TabIndex = 0;
            SummaryLabel.Text = "Loading...";
            // 
            // OneYearRadioButton
            // 
            OneYearRadioButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OneYearRadioButton.Location = new Point(6, 27);
            OneYearRadioButton.Margin = new Padding(3, 4, 3, 4);
            OneYearRadioButton.Name = "OneYearRadioButton";
            OneYearRadioButton.Size = new Size(108, 28);
            OneYearRadioButton.TabIndex = 1;
            OneYearRadioButton.Text = "1 Years";
            oneyeartooltip.SetToolTip(OneYearRadioButton, "Click to take Loan for 1 year");
            OneYearRadioButton.CheckedChanged += OneYearRadioButton_CheckedChanged;
            // 
            // ThreeYearsRadioButton
            // 
            ThreeYearsRadioButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThreeYearsRadioButton.Location = new Point(6, 72);
            ThreeYearsRadioButton.Margin = new Padding(3, 4, 3, 4);
            ThreeYearsRadioButton.Name = "ThreeYearsRadioButton";
            ThreeYearsRadioButton.Size = new Size(108, 25);
            ThreeYearsRadioButton.TabIndex = 2;
            ThreeYearsRadioButton.Text = "3 Years";
            threeyeartoolTip.SetToolTip(ThreeYearsRadioButton, "Click to take loan for 3 year");
            ThreeYearsRadioButton.CheckedChanged += ThreeYearsRadioButton_CheckedChanged;
            // 
            // FiveYearsRadioButton
            // 
            FiveYearsRadioButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FiveYearsRadioButton.Location = new Point(130, 27);
            FiveYearsRadioButton.Margin = new Padding(3, 4, 3, 4);
            FiveYearsRadioButton.Name = "FiveYearsRadioButton";
            FiveYearsRadioButton.Size = new Size(114, 25);
            FiveYearsRadioButton.TabIndex = 3;
            FiveYearsRadioButton.Text = "5 Years";
            fiveyeartooltip.SetToolTip(FiveYearsRadioButton, "Click to take loan for 5 years");
            FiveYearsRadioButton.CheckedChanged += FiveYearsRadioButton_CheckedChanged;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = SystemColors.ActiveCaptionText;
            SubmitButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = Color.Transparent;
            SubmitButton.Location = new Point(340, 456);
            SubmitButton.Margin = new Padding(3, 4, 3, 4);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(119, 38);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&SUBMIT";
            Submittooltip.SetToolTip(SubmitButton, "Click to Submit");
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.Transparent;
            BackButton.Location = new Point(340, 507);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(119, 38);
            BackButton.TabIndex = 5;
            BackButton.Text = "&BACK";
            Backtooltip.SetToolTip(BackButton, "Click to go back");
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // LoanGroupbox
            // 
            LoanGroupbox.BackColor = Color.Gold;
            LoanGroupbox.Controls.Add(Noloanradiobutton);
            LoanGroupbox.Controls.Add(OneYearRadioButton);
            LoanGroupbox.Controls.Add(ThreeYearsRadioButton);
            LoanGroupbox.Controls.Add(FiveYearsRadioButton);
            LoanGroupbox.Location = new Point(56, 442);
            LoanGroupbox.Name = "LoanGroupbox";
            LoanGroupbox.Size = new Size(250, 125);
            LoanGroupbox.TabIndex = 6;
            LoanGroupbox.TabStop = false;
            // 
            // Noloanradiobutton
            // 
            Noloanradiobutton.AccessibleName = "NoloanRadioButton";
            Noloanradiobutton.AutoSize = true;
            Noloanradiobutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Noloanradiobutton.Location = new Point(120, 72);
            Noloanradiobutton.Name = "Noloanradiobutton";
            Noloanradiobutton.Size = new Size(114, 29);
            Noloanradiobutton.TabIndex = 4;
            Noloanradiobutton.TabStop = true;
            Noloanradiobutton.Text = "&No Loan";
            NoloantoolTip.SetToolTip(Noloanradiobutton, "Click if You dont want loan");
            Noloanradiobutton.UseVisualStyleBackColor = true;
            Noloanradiobutton.CheckedChanged += Noloanradiobutton_CheckedChanged;
            // 
            // LoanCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 579);
            Controls.Add(LoanGroupbox);
            Controls.Add(SummaryLabel);
            Controls.Add(SubmitButton);
            Controls.Add(BackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoanCalculatorForm";
            Text = "Loan Calculator";
            Load += LoanCalculatorForm_Load;
            LoanGroupbox.ResumeLayout(false);
            LoanGroupbox.PerformLayout();
            ResumeLayout(false);
        }
        private GroupBox LoanGroupbox;
        private RadioButton Noloanradiobutton;
        private ToolTip oneyeartooltip;
        private ToolTip fiveyeartooltip;
        private ToolTip threeyeartoolTip;
        private ToolTip NoloantoolTip;
        private ToolTip Submittooltip;
        private ToolTip Backtooltip;
    }
}