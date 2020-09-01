namespace Example.Forms
{
    partial class FailedForm
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
            this.FailOKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FailOKButton
            // 
            this.FailOKButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FailOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FailOKButton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold);
            this.FailOKButton.Location = new System.Drawing.Point(125, 97);
            this.FailOKButton.Name = "FailOKButton";
            this.FailOKButton.Size = new System.Drawing.Size(77, 30);
            this.FailOKButton.TabIndex = 1;
            this.FailOKButton.Text = "OK!";
            this.FailOKButton.UseVisualStyleBackColor = false;
            this.FailOKButton.Click += new System.EventHandler(this.FailOKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "Failed to cahnge Username and Password";
            // 
            // FailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(321, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FailOKButton);
            this.Name = "FailedForm";
            this.Text = "FailedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FailOKButton;
        private System.Windows.Forms.Label label1;
    }
}