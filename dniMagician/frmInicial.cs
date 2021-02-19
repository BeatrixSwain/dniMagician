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
            lbError.Text = String.Empty;
            txtResult.Text = String.Empty;

            String newDNI = String.Empty;
            int res = dni.getLetter(txtDNI.Text, out newDNI);
         
            if (res < 0)
            {
                lbError.Text = newDNI;
            }
            else {
                txtResult.Text = newDNI;
            }
        }
         

        //

    }//
}
