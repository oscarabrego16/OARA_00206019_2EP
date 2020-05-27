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
                MessageBox.Show(exception.Message,
                                                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}