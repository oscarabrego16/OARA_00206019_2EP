using System.ComponentModel;

namespace SourceCode
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblBienUser = new System.Windows.Forms.Label();
            this.btnActContra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienUser
            // 
            this.lblBienUser.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBienUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBienUser.Location = new System.Drawing.Point(12, 20);
            this.lblBienUser.Name = "lblBienUser";
            this.lblBienUser.Size = new System.Drawing.Size(213, 41);
            this.lblBienUser.TabIndex = 0;
            this.lblBienUser.Text = "label1";
            // 
            // btnActContra
            // 
            this.btnActContra.BackColor = System.Drawing.Color.White;
            this.btnActContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActContra.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActContra.Location = new System.Drawing.Point(666, 12);
            this.btnActContra.Name = "btnActContra";
            this.btnActContra.Size = new System.Drawing.Size(122, 58);
            this.btnActContra.TabIndex = 1;
            this.btnActContra.Text = "Actualizar contraseña";
            this.btnActContra.UseVisualStyleBackColor = false;
            this.btnActContra.Click += new System.EventHandler(this.btnActContra_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnActContra);
            this.Controls.Add(this.lblBienUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Hugo App";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnActContra;
        private System.Windows.Forms.Label lblBienUser;

        #endregion
    }
}