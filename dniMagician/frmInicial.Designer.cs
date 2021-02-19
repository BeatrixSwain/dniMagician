
namespace dniMagician
{
    partial class frmDNI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.lbInstruc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(32, 38);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(152, 22);
            this.txtDNI.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(238, 33);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 32);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Obtener letra";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(32, 83);
            this.txtResult.MaxLength = 9;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(152, 22);
            this.txtResult.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(224, 83);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(126, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copiar portapapeles";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbError
            // 
            this.lbError.Location = new System.Drawing.Point(32, 118);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(318, 23);
            this.lbError.TabIndex = 4;
            this.lbError.Text = "lbError";
            // 
            // lbInstruc
            // 
            this.lbInstruc.AutoSize = true;
            this.lbInstruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruc.Location = new System.Drawing.Point(29, 5);
            this.lbInstruc.Name = "lbInstruc";
            this.lbInstruc.Size = new System.Drawing.Size(280, 16);
            this.lbInstruc.TabIndex = 5;
            this.lbInstruc.Text = "Inserte los ocho primeros valores del DNI/NIE";
            // 
            // frmDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(383, 148);
            this.Controls.Add(this.lbInstruc);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDNI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDNI";
            this.Text = "DNI VALIDATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbInstruc;
    }
}

