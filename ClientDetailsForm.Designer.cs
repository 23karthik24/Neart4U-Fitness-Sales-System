namespace Assinment_3
{
    partial class ClientDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetailsForm));
            MainGroupBox = new GroupBox();
            ProceedButton = new Button();
            Emaillabel = new Label();
            PhoneNoLabel = new Label();
            PostcodeLabel = new Label();
            EmailtextBox = new TextBox();
            PhonenoTextbox = new TextBox();
            PostcodetextBox = new TextBox();
            FullNametextBox = new TextBox();
            fullnamelabel = new Label();
            ClientDetailsgroupBox = new GroupBox();
            OrderDatetextBox = new TextBox();
            TransNotextBox = new TextBox();
            OrderDatelabel = new Label();
            TransactionNoLabel = new Label();
            ClientDetailLabel = new Label();
            ProceedTooltip = new ToolTip(components);
            MainGroupBox.SuspendLayout();
            ClientDetailsgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainGroupBox
            // 
            MainGroupBox.BackColor = SystemColors.ButtonHighlight;
            MainGroupBox.Controls.Add(ProceedButton);
            MainGroupBox.Controls.Add(Emaillabel);
            MainGroupBox.Controls.Add(PhoneNoLabel);
            MainGroupBox.Controls.Add(PostcodeLabel);
            MainGroupBox.Controls.Add(EmailtextBox);
            MainGroupBox.Controls.Add(PhonenoTextbox);
            MainGroupBox.Controls.Add(PostcodetextBox);
            MainGroupBox.Controls.Add(FullNametextBox);
            MainGroupBox.Controls.Add(fullnamelabel);
            MainGroupBox.Controls.Add(ClientDetailsgroupBox);
            MainGroupBox.ForeColor = SystemColors.ControlLightLight;
            MainGroupBox.Location = new Point(63, 29);
            MainGroupBox.Name = "MainGroupBox";
            MainGroupBox.Size = new Size(667, 442);
            MainGroupBox.TabIndex = 0;
            MainGroupBox.TabStop = false;
            // 
            // ProceedButton
            // 
            ProceedButton.BackColor = Color.Gold;
            ProceedButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProceedButton.ForeColor = SystemColors.ActiveCaptionText;
            ProceedButton.Location = new Point(267, 391);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Size = new Size(114, 33);
            ProceedButton.TabIndex = 10;
            ProceedButton.Text = "Proceed";
            ProceedTooltip.SetToolTip(ProceedButton, "Click to proceed");
            ProceedButton.UseVisualStyleBackColor = false;
            ProceedButton.Click += ProceedButton_Click;
            // 
            // Emaillabel
            // 
            Emaillabel.AutoSize = true;
            Emaillabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emaillabel.ForeColor = SystemColors.ActiveCaptionText;
            Emaillabel.Location = new Point(151, 334);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(164, 25);
            Emaillabel.TabIndex = 9;
            Emaillabel.Text = "Email Address :";
            // 
            // PhoneNoLabel
            // 
            PhoneNoLabel.AutoSize = true;
            PhoneNoLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNoLabel.ForeColor = SystemColors.ActiveCaptionText;
            PhoneNoLabel.Location = new Point(151, 278);
            PhoneNoLabel.Name = "PhoneNoLabel";
            PhoneNoLabel.Size = new Size(120, 25);
            PhoneNoLabel.TabIndex = 8;
            PhoneNoLabel.Text = "Phone No :";
            // 
            // PostcodeLabel
            // 
            PostcodeLabel.AutoSize = true;
            PostcodeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PostcodeLabel.ForeColor = SystemColors.ActiveCaptionText;
            PostcodeLabel.Location = new Point(148, 223);
            PostcodeLabel.Name = "PostcodeLabel";
            PostcodeLabel.Size = new Size(115, 25);
            PostcodeLabel.TabIndex = 7;
            PostcodeLabel.Text = "Postcode :";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(345, 334);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(175, 27);
            EmailtextBox.TabIndex = 6;
            // 
            // PhonenoTextbox
            // 
            PhonenoTextbox.Location = new Point(345, 276);
            PhonenoTextbox.Name = "PhonenoTextbox";
            PhonenoTextbox.Size = new Size(175, 27);
            PhonenoTextbox.TabIndex = 5;
            // 
            // PostcodetextBox
            // 
            PostcodetextBox.Location = new Point(342, 221);
            PostcodetextBox.Name = "PostcodetextBox";
            PostcodetextBox.Size = new Size(178, 27);
            PostcodetextBox.TabIndex = 4;
            // 
            // FullNametextBox
            // 
            FullNametextBox.Location = new Point(342, 160);
            FullNametextBox.Name = "FullNametextBox";
            FullNametextBox.Size = new Size(176, 27);
            FullNametextBox.TabIndex = 3;
            // 
            // fullnamelabel
            // 
            fullnamelabel.AutoSize = true;
            fullnamelabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullnamelabel.ForeColor = SystemColors.ActiveCaptionText;
            fullnamelabel.Location = new Point(151, 162);
            fullnamelabel.Name = "fullnamelabel";
            fullnamelabel.Size = new Size(122, 25);
            fullnamelabel.TabIndex = 2;
            fullnamelabel.Text = "Full Name :";
            // 
            // ClientDetailsgroupBox
            // 
            ClientDetailsgroupBox.BackColor = Color.Gold;
            ClientDetailsgroupBox.Controls.Add(OrderDatetextBox);
            ClientDetailsgroupBox.Controls.Add(TransNotextBox);
            ClientDetailsgroupBox.Controls.Add(OrderDatelabel);
            ClientDetailsgroupBox.Controls.Add(TransactionNoLabel);
            ClientDetailsgroupBox.Controls.Add(ClientDetailLabel);
            ClientDetailsgroupBox.FlatStyle = FlatStyle.Popup;
            ClientDetailsgroupBox.ForeColor = SystemColors.ActiveCaptionText;
            ClientDetailsgroupBox.Location = new Point(6, 26);
            ClientDetailsgroupBox.Name = "ClientDetailsgroupBox";
            ClientDetailsgroupBox.Size = new Size(655, 101);
            ClientDetailsgroupBox.TabIndex = 1;
            ClientDetailsgroupBox.TabStop = false;
            // 
            // OrderDatetextBox
            // 
            OrderDatetextBox.Location = new Point(511, 64);
            OrderDatetextBox.Name = "OrderDatetextBox";
            OrderDatetextBox.Size = new Size(138, 27);
            OrderDatetextBox.TabIndex = 4;
            // 
            // TransNotextBox
            // 
            TransNotextBox.Location = new Point(161, 64);
            TransNotextBox.Name = "TransNotextBox";
            TransNotextBox.Size = new Size(153, 27);
            TransNotextBox.TabIndex = 3;
            // 
            // OrderDatelabel
            // 
            OrderDatelabel.AutoSize = true;
            OrderDatelabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderDatelabel.Location = new Point(390, 71);
            OrderDatelabel.Name = "OrderDatelabel";
            OrderDatelabel.Size = new Size(115, 20);
            OrderDatelabel.TabIndex = 2;
            OrderDatelabel.Text = "Order Date :";
            // 
            // TransactionNoLabel
            // 
            TransactionNoLabel.AutoSize = true;
            TransactionNoLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactionNoLabel.Location = new Point(6, 71);
            TransactionNoLabel.Name = "TransactionNoLabel";
            TransactionNoLabel.Size = new Size(149, 20);
            TransactionNoLabel.TabIndex = 1;
            TransactionNoLabel.Text = "Transaction No :";
            // 
            // ClientDetailLabel
            // 
            ClientDetailLabel.AutoSize = true;
            ClientDetailLabel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientDetailLabel.Location = new Point(145, 0);
            ClientDetailLabel.Name = "ClientDetailLabel";
            ClientDetailLabel.Size = new Size(334, 39);
            ClientDetailLabel.TabIndex = 0;
            ClientDetailLabel.Text = "Client Order Details";
            // 
            // ProceedTooltip
            // 
            ProceedTooltip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // ClientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 483);
            Controls.Add(MainGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClientDetailsForm";
            Text = "ClientDetailsForm";
            MainGroupBox.ResumeLayout(false);
            MainGroupBox.PerformLayout();
            ClientDetailsgroupBox.ResumeLayout(false);
            ClientDetailsgroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MainGroupBox;
        private Label ClientDetailLabel;
        private GroupBox ClientDetailsgroupBox;
        private TextBox OrderDatetextBox;
        private TextBox TransNotextBox;
        private Label OrderDatelabel;
        private Label TransactionNoLabel;
        private Label PostcodeLabel;
        private TextBox EmailtextBox;
        private TextBox PhonenoTextbox;
        private TextBox PostcodetextBox;
        private TextBox FullNametextBox;
        private Label fullnamelabel;
        private Button ProceedButton;
        private Label Emaillabel;
        private Label PhoneNoLabel;
        private ToolTip ProceedTooltip;
    }
}