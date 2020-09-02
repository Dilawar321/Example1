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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsernametextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernametextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernametextBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernametextBox.ForeColor = System.Drawing.Color.Black;
            this.UsernametextBox.Location = new System.Drawing.Point(245, 36);
            this.UsernametextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(217, 25);
            this.UsernametextBox.TabIndex = 1;
            this.UsernametextBox.TextChanged += new System.EventHandler(this.UsernametextBox_TextChanged);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PasswordtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordtextBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordtextBox.Location = new System.Drawing.Point(245, 81);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(217, 25);
            this.PasswordtextBox.TabIndex = 2;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(150, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(150, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.Location = new System.Drawing.Point(390, 114);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(72, 27);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "LogIn";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUplabel
            // 
            this.SignUplabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SignUplabel.AutoSize = true;
            this.SignUplabel.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUplabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SignUplabel.Location = new System.Drawing.Point(277, 145);
            this.SignUplabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SignUplabel.Name = "SignUplabel";
            this.SignUplabel.Size = new System.Drawing.Size(153, 22);
            this.SignUplabel.TabIndex = 7;
            this.SignUplabel.Text = "Change Username and Password?";
            this.SignUplabel.Click += new System.EventHandler(this.SignUplabel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SignUplabel);
            this.panel1.Controls.Add(this.UsernametextBox);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PasswordtextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(85, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 233);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Example.Properties.Resources.smart_catalogue;
            this.pictureBox1.Location = new System.Drawing.Point(2, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label SignUplabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}