using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FailedForm failedForm = new FailedForm();
            SuccessfulForm successfulForm = new SuccessfulForm();
            // if change is successful
            successfulForm.Show();
            // if change is not successful
           // failedForm.Show();
        }
    }
}
