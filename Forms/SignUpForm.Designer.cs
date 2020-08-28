namespace Example.Forms
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewUsernametextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewUsernameLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewUsernametextBox
            // 
            this.NewUsernametextBox.Location = new System.Drawing.Point(88, 26);
            this.NewUsernametextBox.Name = "NewUsernametextBox";
            this.NewUsernametextBox.Size = new System.Drawing.Size(156, 20);
            this.NewUsernametextBox.TabIndex = 0;
            // 
            // OldPasswordtextBox
            // 
            this.OldPasswordtextBox.Location = new System.Drawing.Point(88, 52);
            this.OldPasswordtextBox.Name = "OldPasswordtextBox";
            this.OldPasswordtextBox.Size = new System.Drawing.Size(156, 20);
            this.OldPasswordtextBox.TabIndex = 1;
            // 
            // NewUsernameLabel
            // 
            this.NewUsernameLabel.AutoSize = true;
            this.NewUsernameLabel.Location = new System.Drawing.Point(10, 29);
            this.NewUsernameLabel.Name = "NewUsernameLabel";
            this.NewUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.NewUsernameLabel.TabIndex = 2;
            this.NewUsernameLabel.Text = "Username";
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(10, 55);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(72, 13);
            this.OldPasswordLabel.TabIndex = 3;
            this.OldPasswordLabel.Text = "Old Password";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(89, 121);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(170, 121);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewPasswordtextBox
            // 
            this.NewPasswordtextBox.Location = new System.Drawing.Point(88, 78);
            this.NewPasswordtextBox.Name = "NewPasswordtextBox";
            this.NewPasswordtextBox.Size = new System.Drawing.Size(156, 20);
            this.NewPasswordtextBox.TabIndex = 6;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(10, 81);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.NewPasswordLabel.TabIndex = 7;
            this.NewPasswordLabel.Text = "New Password";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 156);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.NewPasswordtextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.NewUsernameLabel);
            this.Controls.Add(this.OldPasswordtextBox);
            this.Controls.Add(this.NewUsernametextBox);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewUsernametextBox;
        private System.Windows.Forms.TextBox OldPasswordtextBox;
        private System.Windows.Forms.Label NewUsernameLabel;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
    }
}