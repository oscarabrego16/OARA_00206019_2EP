using System;
using System.Windows.Forms;
using SourceCode.Modelo;

namespace SourceCode
{
    public partial class frmPrincipal : Form
    {
        private AppUser user;
        public frmPrincipal(AppUser pUser)
        {
            InitializeComponent();
            user = pUser;
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienUser.Text = "Bienvenido: " + user.userName;
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
               
            }else{
                dt = ConnectionDB.ExecuteQuery("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address "+
                                                "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au "+
                                                "WHERE ao.idProduct = pr.idProduct "+
                                                "AND ao.idAddress = ad.idAddress "+
                                                "AND ad.idUser = au.idUser;");
                dgvOrdenes.DataSource = dt;
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
                
                var dt = AppUserDAO.GetUser(txtUsername1.Text);
                if(!dt.Equals(null)){
                    throw new AlreadyExistingUsernameException("El usuario ya existe.");
                }
                AppUserDAO.CrearNuevo(txtFullname.Text, txtUsername1.Text, rdbUser.Checked);
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
            }
            catch (Exception exception)
            {
                MessageBox.Show("El negocio no existe.",
                                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AppOrderDAO.CrearNuevo(Convert.ToInt32(txtNewOrderIDNeg.Text), Convert.ToInt32(txtNewOrderNombre.Text));
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
            }
            catch (Exception exception)
            {
                MessageBox.Show("La orden no existe.",
                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}