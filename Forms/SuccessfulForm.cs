﻿using System;
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
    public partial class SuccessfulForm : Form
    {
        public SuccessfulForm()
        {
            InitializeComponent();
        }

        private void SuccessfulOKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
