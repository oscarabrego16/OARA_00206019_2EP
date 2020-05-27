using System;
using System.Windows.Forms;
using SourceCode.Modelo;

namespace SourceCode
{
    public partial class frmCambiarContra : Form
    {
        private AppUser user;
        public frmCambiarContra(AppUser pUser)
        {
            InitializeComponent();
            user = pUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtPass1.Text.Equals(txtPass2.Text))&& txtPass1.Text.Length>0)
            {
                try
                {
                     AppUserDAO.UpdatePass(txtPass2.Text, user);
                     MessageBox.Show("Contraseña actualizada.","Hugo App",
                         MessageBoxButtons.OK,MessageBoxIcon.Information);
                     this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coindicen","Hugo App",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}