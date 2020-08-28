namespace Example.Forms
{
    partial class SuccessfulForm
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
            this.Successfullabel = new System.Windows.Forms.Label();
            this.SuccessfulOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Successfullabel
            // 
            this.Successfullabel.AutoSize = true;
            this.Successfullabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Successfullabel.Location = new System.Drawing.Point(-2, 38);
            this.Successfullabel.Name = "Successfullabel";
            this.Successfullabel.Size = new System.Drawing.Size(286, 16);
            this.Successfullabel.TabIndex = 0;
            this.Successfullabel.Text = "Successfully cahnge Username and Password";
            // 
            // SuccessfulOKButton
            // 
            this.SuccessfulOKButton.Location = new System.Drawing.Point(104, 83);
            this.SuccessfulOKButton.Name = "SuccessfulOKButton";
            this.SuccessfulOKButton.Size = new System.Drawing.Size(75, 23);
            this.SuccessfulOKButton.TabIndex = 1;
            this.SuccessfulOKButton.Text = "OK";
            this.SuccessfulOKButton.UseVisualStyleBackColor = true;
            this.SuccessfulOKButton.Click += new System.EventHandler(this.SuccessfulOKButton_Click);
            // 
            // SuccessfulForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.SuccessfulOKButton);
            this.Controls.Add(this.Successfullabel);
            this.Name = "SuccessfulForm";
            this.Text = "SuccessfulForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Successfullabel;
        private System.Windows.Forms.Button SuccessfulOKButton;
    }
}