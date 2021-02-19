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
    public partial class frmCheckDNI : Form
    {
        private controller.dniClass dni = new controller.dniClass();
        private Boolean debug;
        public frmCheckDNI(Boolean _debug)
        {
            InitializeComponent();
            debug = _debug;
            lbError.Text = String.Empty;
            lbResultado.Text = String.Empty;
        }

        private void btnCheckDNI_Click(object sender, EventArgs e)
        {
            try
            {
                lbError.Text = String.Empty;
                lbResultado.Text = String.Empty;

                String newDNI = String.Empty;
                int res = dni.processDNI(txtDNI.Text.Trim().ToUpper(), out newDNI);
                if (res < 0)
                {
                    lbError.Text = newDNI;
                }
                else
                {
                    if (dni.checkDNI(txtDNI.Text.Trim().ToUpper(), newDNI))
                    {
                        lbResultado.Text = "DNI VÁLIDO";
                    }
                    else {
                        lbResultado.Text = "DNI no válido";
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al procesar la petición:" + Environment.NewLine + "Message: " + ex.Message);
            }
        }
    }
}
