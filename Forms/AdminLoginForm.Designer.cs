namespace Example.Forms
{
    partial class AdminLoginForm
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
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUplabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernametextBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernametextBox.ForeColor = System.Drawing.Color.Black;
            this.UsernametextBox.Location = new System.Drawing.Point(279, 165);
            this.UsernametextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(217, 25);
            this.UsernametextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordtextBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordtextBox.Location = new System.Drawing.Point(279, 205);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(217, 25);
            this.PasswordtextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(184, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(184, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.Location = new System.Drawing.Point(424, 238);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(72, 27);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LogIn";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // SignUplabel
            // 
            this.SignUplabel.AutoSize = true;
            this.SignUplabel.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUplabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SignUplabel.Location = new System.Drawing.Point(312, 269);
            this.SignUplabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SignUplabel.Name = "SignUplabel";
            this.SignUplabel.Size = new System.Drawing.Size(153, 22);
            this.SignUplabel.TabIndex = 7;
            this.SignUplabel.Text = "Change Username and Password?";
            this.SignUplabel.Click += new System.EventHandler(this.SignUplabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "LogIn";
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(686, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUplabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label SignUplabel;
        private System.Windows.Forms.Label label1;
    }
}