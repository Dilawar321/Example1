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
            this.Failedlabel = new System.Windows.Forms.Label();
            this.FailOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Failedlabel
            // 
            this.Failedlabel.AutoSize = true;
            this.Failedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Failedlabel.Location = new System.Drawing.Point(1, 47);
            this.Failedlabel.Name = "Failedlabel";
            this.Failedlabel.Size = new System.Drawing.Size(263, 16);
            this.Failedlabel.TabIndex = 0;
            this.Failedlabel.Text = "Failed to cahnge Username and Password";
            // 
            // FailOKButton
            // 
            this.FailOKButton.Location = new System.Drawing.Point(95, 80);
            this.FailOKButton.Name = "FailOKButton";
            this.FailOKButton.Size = new System.Drawing.Size(75, 23);
            this.FailOKButton.TabIndex = 1;
            this.FailOKButton.Text = "OK";
            this.FailOKButton.UseVisualStyleBackColor = true;
            this.FailOKButton.Click += new System.EventHandler(this.FailOKButton_Click);
            // 
            // FailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 115);
            this.Controls.Add(this.FailOKButton);
            this.Controls.Add(this.Failedlabel);
            this.Name = "FailedForm";
            this.Text = "FailedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Failedlabel;
        private System.Windows.Forms.Button FailOKButton;
    }
}