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
    public partial class frmDNI : Form
    {
        private controller.dniClass dni = new controller.dniClass();
        public frmDNI()
        {
            InitializeComponent();
            lbError.Text = String.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lbError.Text = String.Empty;
                txtResult.Text = String.Empty;

                String newDNI = String.Empty;
                int res = dni.processDNI(txtDNI.Text, out newDNI);

                if (res < 0)
                {
                    lbError.Text = newDNI;
                }
                else
                {
                    txtResult.Text = newDNI;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al procesar la petición:" + Environment.NewLine + "Message: " + ex.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try {
                if (txtResult.Text.Trim().Length > 0)
                {
                    Clipboard.SetText(txtResult.Text);
                    lbError.Text = "¡DNI copiado!";
                }
                else {
                    lbError.Text = "No hay nada que copiar :(";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al procesar la petición:" + Environment.NewLine + "Message: " + ex.Message);
            }
        }


        //

    }//
}
