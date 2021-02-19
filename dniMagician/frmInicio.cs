﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dniMagician
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnGetLetter_Click(object sender, EventArgs e)
        {
            try
            {
                frmGetLetterDNI dni = new frmGetLetterDNI();
                dni.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckCIF_Click(object sender, EventArgs e)
        {
            try
            {
                frmCheckCIF cif = new frmCheckCIF();
                cif.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
