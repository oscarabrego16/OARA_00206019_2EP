﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SourceCode.Modelo;
using LiveCharts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace SourceCode
{
    public partial class frmPrincipal : Form
    {
        private AppUser user;
        private CartesianChart graficoEstadisticas;
        public frmPrincipal(AppUser pUser)
        {
            InitializeComponent();
            user = pUser;
            if (!user.userType)
            {
                graficoEstadisticas = new CartesianChart();
                this.Controls.Add(graficoEstadisticas);
                graficoEstadisticas.Parent = tabControl1.TabPages[6];
            }
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienUser.Text = "Bienvenido: " + user.userName;
            
            
            if (user.userType)
            {
                tabControl1.TabPages[6].Parent = null;
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null;
                tabControl1.TabPages[0].Parent = null;
                ActualizarControles();
            }else{
                tabControl1.TabPages[4].Parent = null;
                tabControl1.TabPages[4].Parent = null;
                configurarGrafico();
                ActualizarControles();
             
            }
            
            
        }
        private void configurarGrafico()
        {
            graficoEstadisticas.Top = 10;
            graficoEstadisticas.Left = 10;
            graficoEstadisticas.Width = graficoEstadisticas.Parent.Width - 20;
            graficoEstadisticas.Height = graficoEstadisticas.Parent.Height - 20;

            graficoEstadisticas.Series = new SeriesCollection
            {
                new ColumnSeries{Title = "Negocio", Values = new ChartValues<int>(), DataLabels = true}
            };
            graficoEstadisticas.AxisX.Add(new Axis{Labels = new List<string>()});
            graficoEstadisticas.AxisX[0].Separator = new Separator() {Step = 1, IsEnabled = false};
            graficoEstadisticas.LegendLocation = LegendLocation.Top;
        }
        private void ActualizarControles()
        {
            
            var dt = ConnectionDB.ExecuteQuery("SELECT * FROM appuser");
            dataGridView1.DataSource= dt;
            dt = ConnectionDB.ExecuteQuery("SELECT * FROM business");
            dgvNegocio.DataSource= dt;
            dt = ConnectionDB.ExecuteQuery("SELECT b.idbusiness AS \"ID Negocio\", b.name AS \"Nombre Negocio\","+
                                           " p.idproduct AS \"ID producto\", p.name AS \"Nombre Producto\" " +
                                            "FROM business b, product p WHERE p.idbusiness = b.idbusiness");
            dgvProducto.DataSource = dt;
            
            if(user.userType){
                dt = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address "+
                                                "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                                "WHERE ao.idProduct = pr.idProduct "+
                                                "AND ao.idAddress = ad.idAddress "+
                                                "AND ad.idUser = au.idUser "+
                                                $"AND au.idUser = {user.idUser};");
               dgvOrdenes.DataSource = dt;
               dt= ConnectionDB.ExecuteQuery("SELECT p.idproduct AS \"ID producto\", p.name AS \"Producto\", b.name AS \"Negocio\" "+
                                             "FROM product p, business b WHERE p.idbusiness = b.idbusiness");
               dgvNewOrder1.DataSource = dt;
               dt= ConnectionDB.ExecuteQuery($"SELECT idaddress AS \"ID Direccion\", address AS \"Direccion\" " +
                                             $"FROM address WHERE iduser={user.idUser};");
               dgvNewOrder2.DataSource = dt;
               dt= ConnectionDB.ExecuteQuery($"SELECT * FROM address " +
                                             $"WHERE iduser= {user.idUser};");
               dgvDirecciones.DataSource = dt;

            }else{
            poblarGrafico();
                dt = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address "+
                                                "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                                "WHERE ao.idProduct = pr.idProduct "+
                                                "AND ao.idAddress = ad.idAddress "+
                                                "AND ad.idUser = au.idUser;");
                dgvOrdenes.DataSource = dt;
            }
        }
        private void poblarGrafico()
        {
            graficoEstadisticas.Series[0].Values.Clear();
            graficoEstadisticas.AxisX[0].Labels.Clear();
            
            foreach (Pedidos f in PedidosDAO.getEstadisticas())
            {
                graficoEstadisticas.Series[0].Values.Add(f.cantidad);
                graficoEstadisticas.AxisX[0].Labels.Add(f.negocio);
            }
        }
        private void btnActContra_Click(object sender, EventArgs e)
        {
            frmCambiarContra ventana = new frmCambiarContra(user);
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AppUserDAO.CrearNuevo(txtFullname.Text, (txtUsername1.Text).ToLower(), rdbUser.Checked);
                                    MessageBox.Show("Ingresado con exito",
                                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ActualizarControles();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                AppUserDAO.EliminarUser(txtUsername2.Text);
                MessageBox.Show("Eliminado con exito",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("El usuario no existe.",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnAddNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessDAO.CrearNuevo(txtBusName.Text, txtBusDesc.Text);
                MessageBox.Show("Ingresado con exito",
                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnEliminarNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessDAO.EliminarBus(Convert.ToInt32(txtBusID.Text));
                MessageBox.Show("Eliminado con exito",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("El negocio no existe.",
                                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDAO.CrearNuevo(Convert.ToInt32(txtNegocioProd.Text), txtNombreProd.Text);
                MessageBox.Show("Agregado con exito",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDAO.EliminarProd(Convert.ToInt32(txtIDProd.Text));
                MessageBox.Show("Eliminado con exito",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("El producto no existe.",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AppOrderDAO.CrearNuevo(Convert.ToInt32(txtNewOrderIDNeg.Text), Convert.ToInt32(txtNewOrderNombre.Text));
                MessageBox.Show("Ingresado con exito",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnDelNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                AppOrderDAO.EliminarOrder(Convert.ToInt32(txtDelOrderID.Text));
                MessageBox.Show("Eliminado con exito",
                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("La orden no existe.",
                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

    
    private void btnAddDireccion_Click(object sender, EventArgs e)
    {
        try
        {
                    AddressDAO.CrearNuevo(user.idUser, txtNewDir.Text);
                    MessageBox.Show("Ingresado con exito",
                                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarControles();
               }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
    }

    private void btnDelDireccion_Click(object sender, EventArgs e)
    {
        try
        {
            AddressDAO.EliminarDir(Convert.ToInt32(txtDelDir.Text));
            MessageBox.Show("Eliminado con exito",
                "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarControles();
        }
        catch (Exception exception)
        {
            MessageBox.Show("La dirccion no existe.",
                                                "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw;
        }
    }
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e){
    ActualizarControles();
    }


    private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (MessageBox.Show("¿Seguro que desea salir?", 
            "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
    }
}