﻿
namespace dniMagician
{
    partial class frmInicio
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
            this.btnGetLetter = new System.Windows.Forms.Button();
            this.btnCheckCIF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetLetter
            // 
            this.btnGetLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLetter.Location = new System.Drawing.Point(47, 93);
            this.btnGetLetter.Name = "btnGetLetter";
            this.btnGetLetter.Size = new System.Drawing.Size(75, 23);
            this.btnGetLetter.TabIndex = 0;
            this.btnGetLetter.Text = "Get letter";
            this.btnGetLetter.UseVisualStyleBackColor = true;
            this.btnGetLetter.Click += new System.EventHandler(this.btnGetLetter_Click);
            // 
            // btnCheckCIF
            // 
            this.btnCheckCIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCIF.Location = new System.Drawing.Point(162, 93);
            this.btnCheckCIF.Name = "btnCheckCIF";
            this.btnCheckCIF.Size = new System.Drawing.Size(75, 23);
            this.btnCheckCIF.TabIndex = 1;
            this.btnCheckCIF.Text = "Check CIF";
            this.btnCheckCIF.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(423, 229);
            this.Controls.Add(this.btnCheckCIF);
            this.Controls.Add(this.btnGetLetter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetLetter;
        private System.Windows.Forms.Button btnCheckCIF;
    }
}