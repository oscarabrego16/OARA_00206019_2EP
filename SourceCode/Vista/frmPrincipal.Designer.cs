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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNegocioProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtDelOrderID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelNewOrder = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtNewOrderNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewOrderIDNeg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.dgvNewOrder2 = new System.Windows.Forms.DataGridView();
            this.dgvNewOrder1 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtDelDir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelDireccion = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtNewDir = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddDireccion = new System.Windows.Forms.Button();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNegocio)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProducto)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenes)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNewOrder2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNewOrder1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirecciones)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(20, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 482);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.dgvProducto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtIDProd);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.btnEliminarProd);
            this.groupBox5.Location = new System.Drawing.Point(464, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(282, 172);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar Producto";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(124, 51);
            this.txtIDProd.MaxLength = 25;
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(141, 20);
            this.txtIDProd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label7.Location = new System.Drawing.Point(7, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 41);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID producto";
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarProd.Location = new System.Drawing.Point(96, 113);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(113, 53);
            this.btnEliminarProd.TabIndex = 5;
            this.btnEliminarProd.Text = "Eliminar producto";
            this.btnEliminarProd.UseVisualStyleBackColor = true;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNombreProd);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtNegocioProd);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.btnAddProd);
            this.groupBox6.Location = new System.Drawing.Point(20, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(422, 172);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Agregar Producto";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(123, 74);
            this.txtNombreProd.MaxLength = 100;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(141, 20);
            this.txtNombreProd.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 59);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre producto";
            // 
            // txtNegocioProd
            // 
            this.txtNegocioProd.Location = new System.Drawing.Point(123, 33);
            this.txtNegocioProd.MaxLength = 25;
            this.txtNegocioProd.Name = "txtNegocioProd";
            this.txtNegocioProd.Size = new System.Drawing.Size(141, 20);
            this.txtNegocioProd.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 41);
            this.label9.TabIndex = 3;
            this.label9.Text = "ID Negocio";
            // 
            // btnAddProd
            // 
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddProd.Location = new System.Drawing.Point(123, 113);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(113, 53);
            this.btnAddProd.TabIndex = 4;
            this.btnAddProd.Text = "Agregar producto";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(14, 23);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(732, 221);
            this.dgvProducto.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage4.Controls.Add(this.dgvOrdenes);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(760, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Órdenes";
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(14, 22);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.Size = new System.Drawing.Size(732, 419);
            this.dgvOrdenes.TabIndex = 11;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Controls.Add(this.dgvNewOrder2);
            this.tabPage5.Controls.Add(this.dgvNewOrder1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(760, 456);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Nueva Orden";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtDelOrderID);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.btnDelNewOrder);
            this.groupBox7.Location = new System.Drawing.Point(458, 298);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(282, 152);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Eliminar orden";
            // 
            // txtDelOrderID
            // 
            this.txtDelOrderID.Location = new System.Drawing.Point(124, 51);
            this.txtDelOrderID.MaxLength = 25;
            this.txtDelOrderID.Name = "txtDelOrderID";
            this.txtDelOrderID.Size = new System.Drawing.Size(141, 20);
            this.txtDelOrderID.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 41);
            this.label10.TabIndex = 11;
            this.label10.Text = "ID orden";
            // 
            // btnDelNewOrder
            // 
            this.btnDelNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelNewOrder.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelNewOrder.Location = new System.Drawing.Point(81, 93);
            this.btnDelNewOrder.Name = "btnDelNewOrder";
            this.btnDelNewOrder.Size = new System.Drawing.Size(113, 53);
            this.btnDelNewOrder.TabIndex = 5;
            this.btnDelNewOrder.Text = "Eliminar orden";
            this.btnDelNewOrder.UseVisualStyleBackColor = true;
            this.btnDelNewOrder.Click += new System.EventHandler(this.btnDelNewOrder_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtNewOrderNombre);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.txtNewOrderIDNeg);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.btnAddNewOrder);
            this.groupBox8.Location = new System.Drawing.Point(14, 298);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(422, 152);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Agregar orden";
            // 
            // txtNewOrderNombre
            // 
            this.txtNewOrderNombre.Location = new System.Drawing.Point(123, 74);
            this.txtNewOrderNombre.MaxLength = 100;
            this.txtNewOrderNombre.Name = "txtNewOrderNombre";
            this.txtNewOrderNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNewOrderNombre.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label11.Location = new System.Drawing.Point(6, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 41);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID Direccion";
            // 
            // txtNewOrderIDNeg
            // 
            this.txtNewOrderIDNeg.Location = new System.Drawing.Point(123, 33);
            this.txtNewOrderIDNeg.MaxLength = 25;
            this.txtNewOrderIDNeg.Name = "txtNewOrderIDNeg";
            this.txtNewOrderIDNeg.Size = new System.Drawing.Size(141, 20);
            this.txtNewOrderIDNeg.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 41);
            this.label12.TabIndex = 3;
            this.label12.Text = "ID Producto";
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewOrder.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddNewOrder.Location = new System.Drawing.Point(123, 100);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(113, 52);
            this.btnAddNewOrder.TabIndex = 4;
            this.btnAddNewOrder.Text = "Agregar orden";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvNewOrder2
            // 
            this.dgvNewOrder2.AllowUserToAddRows = false;
            this.dgvNewOrder2.AllowUserToDeleteRows = false;
            this.dgvNewOrder2.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dgvNewOrder2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewOrder2.Location = new System.Drawing.Point(388, 19);
            this.dgvNewOrder2.Name = "dgvNewOrder2";
            this.dgvNewOrder2.ReadOnly = true;
            this.dgvNewOrder2.Size = new System.Drawing.Size(349, 273);
            this.dgvNewOrder2.TabIndex = 13;
            // 
            // dgvNewOrder1
            // 
            this.dgvNewOrder1.AllowUserToAddRows = false;
            this.dgvNewOrder1.AllowUserToDeleteRows = false;
            this.dgvNewOrder1.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dgvNewOrder1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewOrder1.Location = new System.Drawing.Point(14, 19);
            this.dgvNewOrder1.Name = "dgvNewOrder1";
            this.dgvNewOrder1.ReadOnly = true;
            this.dgvNewOrder1.Size = new System.Drawing.Size(349, 273);
            this.dgvNewOrder1.TabIndex = 12;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage6.Controls.Add(this.groupBox9);
            this.tabPage6.Controls.Add(this.groupBox10);
            this.tabPage6.Controls.Add(this.dgvDirecciones);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(760, 456);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Direcciones";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDelDir);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.btnDelDireccion);
            this.groupBox9.Location = new System.Drawing.Point(385, 268);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(361, 160);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Eliminar dirección";
            // 
            // txtDelDir
            // 
            this.txtDelDir.Location = new System.Drawing.Point(124, 51);
            this.txtDelDir.MaxLength = 25;
            this.txtDelDir.Name = "txtDelDir";
            this.txtDelDir.Size = new System.Drawing.Size(141, 20);
            this.txtDelDir.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label13.Location = new System.Drawing.Point(7, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 41);
            this.label13.TabIndex = 11;
            this.label13.Text = "ID dirección:";
            // 
            // btnDelDireccion
            // 
            this.btnDelDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDireccion.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelDireccion.Location = new System.Drawing.Point(98, 92);
            this.btnDelDireccion.Name = "btnDelDireccion";
            this.btnDelDireccion.Size = new System.Drawing.Size(113, 53);
            this.btnDelDireccion.TabIndex = 5;
            this.btnDelDireccion.Text = "Eliminar dirección";
            this.btnDelDireccion.UseVisualStyleBackColor = true;
            this.btnDelDireccion.Click += new System.EventHandler(this.btnDelDireccion_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtNewDir);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.btnAddDireccion);
            this.groupBox10.Location = new System.Drawing.Point(20, 268);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(336, 160);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Agregar dirección";
            // 
            // txtNewDir
            // 
            this.txtNewDir.Location = new System.Drawing.Point(153, 30);
            this.txtNewDir.MaxLength = 1000;
            this.txtNewDir.Multiline = true;
            this.txtNewDir.Name = "txtNewDir";
            this.txtNewDir.Size = new System.Drawing.Size(141, 115);
            this.txtNewDir.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (0)))), ((int) (((byte) (64)))));
            this.label15.Location = new System.Drawing.Point(6, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 41);
            this.label15.TabIndex = 3;
            this.label15.Text = "Dirección:";
            // 
            // btnAddDireccion
            // 
            this.btnAddDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDireccion.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddDireccion.Location = new System.Drawing.Point(6, 92);
            this.btnAddDireccion.Name = "btnAddDireccion";
            this.btnAddDireccion.Size = new System.Drawing.Size(113, 53);
            this.btnAddDireccion.TabIndex = 4;
            this.btnAddDireccion.Text = "Agregar dirección";
            this.btnAddDireccion.UseVisualStyleBackColor = true;
            this.btnAddDireccion.Click += new System.EventHandler(this.btnAddDireccion_Click);
            // 
            // dgvDirecciones
            // 
            this.dgvDirecciones.AllowUserToAddRows = false;
            this.dgvDirecciones.AllowUserToDeleteRows = false;
            this.dgvDirecciones.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (51)))), ((int) (((byte) (0)))), ((int) (((byte) (51)))));
            this.dgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.Location = new System.Drawing.Point(14, 29);
            this.dgvDirecciones.Name = "dgvDirecciones";
            this.dgvDirecciones.ReadOnly = true;
            this.dgvDirecciones.Size = new System.Drawing.Size(732, 221);
            this.dgvDirecciones.TabIndex = 7;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (230)))), ((int) (((byte) (255)))));
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(760, 456);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Gráfico";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProducto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenes)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNewOrder2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNewOrder1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirecciones)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnActContra;
        private System.Windows.Forms.Button btnAddDireccion;
        private System.Windows.Forms.Button btnAddNegocio;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDelDireccion;
        private System.Windows.Forms.Button btnDelNewOrder;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarNegocio;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.DataGridView dgvNegocio;
        private System.Windows.Forms.DataGridView dgvNewOrder1;
        private System.Windows.Forms.DataGridView dgvNewOrder2;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBienUser;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtBusDesc;
        private System.Windows.Forms.TextBox txtBusID;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.TextBox txtDelDir;
        private System.Windows.Forms.TextBox txtDelOrderID;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.TextBox txtNegocioProd;
        private System.Windows.Forms.TextBox txtNewDir;
        private System.Windows.Forms.TextBox txtNewOrderIDNeg;
        private System.Windows.Forms.TextBox txtNewOrderNombre;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.TextBox txtUsername2;

        #endregion
    }
}