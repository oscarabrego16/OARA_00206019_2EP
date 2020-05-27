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

       
    }
}