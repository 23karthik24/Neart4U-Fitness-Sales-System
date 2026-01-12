namespace Assinment_3
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox keywordgroupBox;
        private System.Windows.Forms.Label Keywordslabel;
        private System.Windows.Forms.TextBox Searchtextbox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.RadioButton transradiobutton;
        private System.Windows.Forms.RadioButton emailradioButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ClearButton;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            keywordgroupBox = new GroupBox();
            emailradioButton = new RadioButton();
            transradiobutton = new RadioButton();
            Searchbutton = new Button();
            Searchtextbox = new TextBox();
            Keywordslabel = new Label();
            OutputLabel = new Label();
            ClearButton = new Button();
            BackButton = new Button();
            keywordgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // keywordgroupBox
            // 
            keywordgroupBox.BackColor = Color.Gold;
            keywordgroupBox.Controls.Add(emailradioButton);
            keywordgroupBox.Controls.Add(transradiobutton);
            keywordgroupBox.Controls.Add(Searchbutton);
            keywordgroupBox.Controls.Add(Searchtextbox);
            keywordgroupBox.Controls.Add(Keywordslabel);
            keywordgroupBox.Location = new Point(20, 25);
            keywordgroupBox.Margin = new Padding(3, 4, 3, 4);
            keywordgroupBox.Name = "keywordgroupBox";
            keywordgroupBox.Padding = new Padding(3, 4, 3, 4);
            keywordgroupBox.Size = new Size(500, 188);
            keywordgroupBox.TabIndex = 0;
            keywordgroupBox.TabStop = false;
            // 
            // emailradioButton
            // 
            emailradioButton.AutoSize = true;
            emailradioButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailradioButton.Location = new Point(120, 125);
            emailradioButton.Margin = new Padding(3, 4, 3, 4);
            emailradioButton.Name = "emailradioButton";
            emailradioButton.Size = new Size(137, 22);
            emailradioButton.TabIndex = 4;
            emailradioButton.Text = "Email Address";
            emailradioButton.UseVisualStyleBackColor = true;
            // 
            // transradiobutton
            // 
            transradiobutton.AutoSize = true;
            transradiobutton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transradiobutton.Location = new Point(120, 88);
            transradiobutton.Margin = new Padding(3, 4, 3, 4);
            transradiobutton.Name = "transradiobutton";
            transradiobutton.Size = new Size(182, 22);
            transradiobutton.TabIndex = 3;
            transradiobutton.Text = "Transaction Number";
            transradiobutton.UseVisualStyleBackColor = true;
            // 
            // Searchbutton
            // 
            Searchbutton.BackColor = Color.Black;
            Searchbutton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbutton.ForeColor = SystemColors.ButtonHighlight;
            Searchbutton.Location = new Point(340, 31);
            Searchbutton.Margin = new Padding(3, 4, 3, 4);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(100, 38);
            Searchbutton.TabIndex = 2;
            Searchbutton.Text = "SEARCH";
            Searchbutton.UseVisualStyleBackColor = false;
            Searchbutton.Click += Searchbutton_Click;
            // 
            // Searchtextbox
            // 
            Searchtextbox.Location = new Point(120, 34);
            Searchtextbox.Margin = new Padding(3, 4, 3, 4);
            Searchtextbox.Name = "Searchtextbox";
            Searchtextbox.Size = new Size(200, 27);
            Searchtextbox.TabIndex = 1;
            // 
            // Keywordslabel
            // 
            Keywordslabel.AutoSize = true;
            Keywordslabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Keywordslabel.Location = new Point(6, 37);
            Keywordslabel.Name = "Keywordslabel";
            Keywordslabel.Size = new Size(111, 18);
            Keywordslabel.TabIndex = 0;
            Keywordslabel.Text = "Enter Search:";
            // 
            // OutputLabel
            // 
            OutputLabel.BackColor = Color.Gold;
            OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            OutputLabel.Location = new Point(20, 217);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(500, 300);
            OutputLabel.TabIndex = 1;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(294, 521);
            ClearButton.Margin = new Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(80, 38);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click_1;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(426, 521);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(80, 38);
            BackButton.TabIndex = 3;
            BackButton.Text = "BACK";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 562);
            Controls.Add(BackButton);
            Controls.Add(ClearButton);
            Controls.Add(OutputLabel);
            Controls.Add(keywordgroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "SearchForm";
            Text = "Search Transactions";
            Load += SearchForm_Load;
            keywordgroupBox.ResumeLayout(false);
            keywordgroupBox.PerformLayout();
            ResumeLayout(false);
        }
    }
}