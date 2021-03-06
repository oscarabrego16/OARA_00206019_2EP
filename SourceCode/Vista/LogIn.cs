﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceCode.Modelo;

namespace SourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                var user = AppUserDAO.GetUser(txtUser.Text, txtPass.Text);
                if (user.fullName.Equals(""))
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos","Hugo App",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bienvenido","Hugo App",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmPrincipal ventana = new frmPrincipal(user);
                    ventana.Show();
                    this.Hide();
                
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}