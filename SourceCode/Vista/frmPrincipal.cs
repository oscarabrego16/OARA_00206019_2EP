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
            
        }


        private void btnActContra_Click(object sender, EventArgs e)
        {
            frmCambiarContra ventana = new frmCambiarContra(user);
            ventana.ShowDialog();
        }
    }
}