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
    public partial class frmCheckCIF : Form
    {
        private controller.cifClass cif = new controller.cifClass();
        public frmCheckCIF()
        {
            InitializeComponent();
            lbError.Text = String.Empty;
            lbResultado.Text = String.Empty;
        }

        private void btnCheckCIF_Click(object sender, EventArgs e)
        {
            try
            {
                lbError.Text = String.Empty;
                lbResultado.Text = String.Empty;
                model.Company company = new model.Company();
                String message = String.Empty;
                if (cif.checkCIF(txtCIF.Text.Trim().ToUpper(), out company, out message) == 0)
                {
                    lbResultado.Text = "¡Válido!";
                }
                else
                {
                    lbResultado.Text = "El CIF no es válido";
                    lbError.Text = message;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al procesar la petición:" + Environment.NewLine + "Message: " + ex.Message);
            }

        }
    }//
}
