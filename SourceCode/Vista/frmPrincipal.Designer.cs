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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBusID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarNegocio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBusDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddNegocio = new System.Windows.Forms.Button();
            this.dgvNegocio = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNegocio)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(20, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 482);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsername2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(467, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar usuario";
            // 
            // txtUsername2
            // 
            this.txtUsername2.Location = new System.Drawing.Point(124, 51);
            this.txtUsername2.MaxLength = 25;
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(141, 20);
            this.txtUsername2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuario:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.Location = new System.Drawing.Point(98, 92);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 53);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAdmin);
            this.groupBox1.Controls.Add(this.rdbUser);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(23, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar usuario";
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.Location = new System.Drawing.Point(123, 115);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(101, 25);
            this.rdbAdmin.TabIndex = 9;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbUser
            // 
            this.rdbUser.Location = new System.Drawing.Point(16, 115);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(101, 25);
            this.rdbUser.TabIndex = 8;
            this.rdbUser.TabStop = true;
            this.rdbUser.Text = "Usuario";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(123, 74);
            this.txtFullname.MaxLength = 100;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(141, 20);
            this.txtFullname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // txtUsername1
            // 
            this.txtUsername1.Location = new System.Drawing.Point(123, 33);
            this.txtUsername1.MaxLength = 25;
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.Size = new System.Drawing.Size(141, 20);
            this.txtUsername1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.Location = new System.Drawing.Point(290, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 53);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(732, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dgvNegocio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Negocios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBusID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnEliminarNegocio);
            this.groupBox3.Location = new System.Drawing.Point(464, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 172);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Negocio";
            // 
            // txtBusID
            // 
            this.txtBusID.Location = new System.Drawing.Point(124, 51);
            this.txtBusID.MaxLength = 25;
            this.txtBusID.Name = "txtBusID";
            this.txtBusID.Size = new System.Drawing.Size(141, 20);
            this.txtBusID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID negocio:";
            // 
            // btnEliminarNegocio
            // 
            this.btnEliminarNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarNegocio.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarNegocio.Location = new System.Drawing.Point(96, 113);
            this.btnEliminarNegocio.Name = "btnEliminarNegocio";
            this.btnEliminarNegocio.Size = new System.Drawing.Size(113, 53);
            this.btnEliminarNegocio.TabIndex = 5;
            this.btnEliminarNegocio.Text = "Eliminar negocio";
            this.btnEliminarNegocio.UseVisualStyleBackColor = true;
            this.btnEliminarNegocio.Click += new System.EventHandler(this.btnEliminarNegocio_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBusDesc);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtBusName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnAddNegocio);
            this.groupBox4.Location = new System.Drawing.Point(20, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 172);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Negocio";
            // 
            // txtBusDesc
            // 
            this.txtBusDesc.Location = new System.Drawing.Point(123, 74);
            this.txtBusDesc.MaxLength = 100;
            this.txtBusDesc.Name = "txtBusDesc";
            this.txtBusDesc.Size = new System.Drawing.Size(141, 20);
            this.txtBusDesc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripción:";
            // 
            // txtBusName
            // 
            this.txtBusName.Location = new System.Drawing.Point(123, 33);
            this.txtBusName.MaxLength = 25;
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(141, 20);
            this.txtBusName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre:";
            // 
            // btnAddNegocio
            // 
            this.btnAddNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNegocio.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddNegocio.Location = new System.Drawing.Point(123, 113);
            this.btnAddNegocio.Name = "btnAddNegocio";
            this.btnAddNegocio.Size = new System.Drawing.Size(113, 53);
            this.btnAddNegocio.TabIndex = 4;
            this.btnAddNegocio.Text = "Agregar negocio";
            this.btnAddNegocio.UseVisualStyleBackColor = true;
            this.btnAddNegocio.Click += new System.EventHandler(this.btnAddNegocio_Click);
            // 
            // dgvNegocio
            // 
            this.dgvNegocio.AllowUserToAddRows = false;
            this.dgvNegocio.AllowUserToDeleteRows = false;
            this.dgvNegocio.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dgvNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNegocio.Location = new System.Drawing.Point(14, 29);
            this.dgvNegocio.Name = "dgvNegocio";
            this.dgvNegocio.ReadOnly = true;
            this.dgvNegocio.Size = new System.Drawing.Size(732, 221);
            this.dgvNegocio.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(760, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Órdenes";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.ClientSize = new System.Drawing.Size(825, 563);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnActContra);
            this.Controls.Add(this.lblBienUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Hugo App";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNegocio)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnActContra;
        private System.Windows.Forms.Button btnAddNegocio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarNegocio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvNegocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBienUser;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtBusDesc;
        private System.Windows.Forms.TextBox txtBusID;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.TextBox txtUsername2;

        #endregion
    }
}