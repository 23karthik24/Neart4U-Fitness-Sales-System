namespace Assinment_3
{
    partial class Login1
    {
       
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            LoginGroupbox = new GroupBox();
            LoginButton = new Button();
            PasswordtextBox = new TextBox();
            PasswordLabel = new Label();
            SalespersonnametextBox = new TextBox();
            SalesPersonNameLabel = new Label();
            ExitButton = new Button();
            LoginGroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // LoginGroupbox
            // 
            LoginGroupbox.BackColor = Color.Gold;
            LoginGroupbox.Controls.Add(ExitButton);
            LoginGroupbox.Controls.Add(LoginButton);
            LoginGroupbox.Controls.Add(PasswordtextBox);
            LoginGroupbox.Controls.Add(PasswordLabel);
            LoginGroupbox.Controls.Add(SalespersonnametextBox);
            LoginGroupbox.Controls.Add(SalesPersonNameLabel);
            LoginGroupbox.Location = new Point(154, 72);
            LoginGroupbox.Name = "LoginGroupbox";
            LoginGroupbox.Size = new Size(574, 280);
            LoginGroupbox.TabIndex = 0;
            LoginGroupbox.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Black;
            LoginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(212, 169);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(109, 38);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(310, 106);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(201, 27);
            PasswordtextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(67, 108);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(119, 25);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password :";
            // 
            // SalespersonnametextBox
            // 
            SalespersonnametextBox.Location = new Point(310, 48);
            SalespersonnametextBox.Name = "SalespersonnametextBox";
            SalespersonnametextBox.Size = new Size(201, 27);
            SalespersonnametextBox.TabIndex = 1;
            // 
            // SalesPersonNameLabel
            // 
            SalesPersonNameLabel.AutoSize = true;
            SalesPersonNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalesPersonNameLabel.Location = new Point(67, 50);
            SalesPersonNameLabel.Name = "SalesPersonNameLabel";
            SalesPersonNameLabel.Size = new Size(216, 25);
            SalesPersonNameLabel.TabIndex = 0;
            SalesPersonNameLabel.Text = "Sales Person Name :";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Black;
            ExitButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Location = new Point(363, 169);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(109, 38);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            // 
            // Login1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginGroupbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login1";
            Text = "Login1";
            LoginGroupbox.ResumeLayout(false);
            LoginGroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LoginGroupbox;
        private TextBox PasswordtextBox;
        private Label PasswordLabel;
        private TextBox SalespersonnametextBox;
        private Label SalesPersonNameLabel;
        private Button LoginButton;
        private Button ExitButton;
    }
}
