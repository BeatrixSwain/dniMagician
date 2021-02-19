using System;
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
    public partial class frmCompany : Form
    {
        public frmCompany(model.Company company, Boolean debug)
        {
            InitializeComponent();
            if (company != null) {
                if (company.isValid)
                {
                    lbValida.Text += " SÍ.";
                    lbValida.ForeColor = Color.Green;
                }
                else {
                    lbValida.Text += " NO.";
                    lbValida.ForeColor = Color.Red;
                }

                txtCIF.Text = company.CIF;
                txtProvince.Text = company.Province;
                txtType.Text = company.typeSociety;
                //
                txtLT.Text = company.letterType;
                txtNumProvince.Text = company.numProvince.ToString();
                txtDC.Text = company.controlDigit;
                if (debug) {
                    txtLT.Visible = true;
                    txtNumProvince.Visible = true;
                    txtDC.Visible = true;
                    lbLetterType.Visible = true;
                    lbNumProvince.Visible = true;
                    lbControlDigit.Visible = true;
                }

            }
        }


    }
}
