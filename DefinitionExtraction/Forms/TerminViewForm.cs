﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitionExtraction
{
    public partial class TerminViewForm : Form
    {
        public TerminViewForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddControl(TerminControl terminControl)
        {
            terminsPanel.Controls.Add(terminControl);
        }
    }
}
