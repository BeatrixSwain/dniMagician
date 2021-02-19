
namespace dniMagician
{
    partial class frmCheckCIF
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
            this.txtCIF = new System.Windows.Forms.TextBox();
            this.btnCheckCIF = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCIF
            // 
            this.txtCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIF.Location = new System.Drawing.Point(49, 65);
            this.txtCIF.Name = "txtCIF";
            this.txtCIF.Size = new System.Drawing.Size(262, 22);
            this.txtCIF.TabIndex = 0;
            // 
            // btnCheckCIF
            // 
            this.btnCheckCIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCIF.Location = new System.Drawing.Point(122, 102);
            this.btnCheckCIF.Name = "btnCheckCIF";
            this.btnCheckCIF.Size = new System.Drawing.Size(117, 27);
            this.btnCheckCIF.TabIndex = 1;
            this.btnCheckCIF.Text = "Comprobar CIF";
            this.btnCheckCIF.UseVisualStyleBackColor = true;
            this.btnCheckCIF.Click += new System.EventHandler(this.btnCheckCIF_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(49, 8);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(262, 24);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "label1";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbError
            // 
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.Location = new System.Drawing.Point(49, 38);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(262, 24);
            this.lbError.TabIndex = 3;
            this.lbError.Text = "label1";
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmCheckCIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(371, 162);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCheckCIF);
            this.Controls.Add(this.txtCIF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckCIF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHECK CIF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCIF;
        private System.Windows.Forms.Button btnCheckCIF;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbError;
    }
}