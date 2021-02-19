
namespace dniMagician
{
    partial class frmCheckDNI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbInstruc = new System.Windows.Forms.Label();
            this.btnCheckDNI = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInstruc
            // 
            this.lbInstruc.AutoSize = true;
            this.lbInstruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruc.Location = new System.Drawing.Point(27, 30);
            this.lbInstruc.Name = "lbInstruc";
            this.lbInstruc.Size = new System.Drawing.Size(103, 16);
            this.lbInstruc.TabIndex = 8;
            this.lbInstruc.Text = "Inserte  DNI/NIE";
            // 
            // btnCheckDNI
            // 
            this.btnCheckDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDNI.Location = new System.Drawing.Point(236, 58);
            this.btnCheckDNI.Name = "btnCheckDNI";
            this.btnCheckDNI.Size = new System.Drawing.Size(112, 32);
            this.btnCheckDNI.TabIndex = 7;
            this.btnCheckDNI.Text = "Comprobar DNI";
            this.btnCheckDNI.UseVisualStyleBackColor = true;
            this.btnCheckDNI.Click += new System.EventHandler(this.btnCheckDNI_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(30, 63);
            this.txtDNI.MaxLength = 9;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(152, 22);
            this.txtDNI.TabIndex = 6;
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.Location = new System.Drawing.Point(27, 133);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(321, 24);
            this.lbError.TabIndex = 10;
            this.lbError.Text = "label1";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(27, 103);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(321, 24);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "label1";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCheckDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(377, 175);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbInstruc);
            this.Controls.Add(this.btnCheckDNI);
            this.Controls.Add(this.txtDNI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckDNI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInstruc;
        private System.Windows.Forms.Button btnCheckDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbResultado;
    }
}