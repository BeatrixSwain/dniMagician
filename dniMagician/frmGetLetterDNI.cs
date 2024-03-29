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
    public partial class frmGetLetterDNI : Form
    {
        private controller.dniClass dni = new controller.dniClass();
        private Boolean debug;
        public frmGetLetterDNI(Boolean _debug)
        {
            InitializeComponent();
            lbError.Text = String.Empty;
            debug = _debug;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lbError.Text = String.Empty;
                txtResult.Text = String.Empty;

                String newDNI = String.Empty;
                int res = dni.processDNI(txtDNI.Text.Trim().ToUpper(), out newDNI);

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
            try
            {
                if (txtResult.Text.Trim().Length > 0)
                {
                    Clipboard.SetText(txtResult.Text);
                    lbError.Text = "¡DNI copiado!";
                }
                else
                {
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
