using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class frmLogin : Form
    {
        string user = "admin";
        string pass = "1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text=="")
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Usuario...");
                this.txtUsuario.Focus();
                return;
            }
           
            //if (this.txtClave.Text=="")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe ingresar Clave...");
                this.txtClave.Focus();
                return;
            }

            //Validar usuario y clave

            string msj = "";
            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
            {
                msj = "Login OK";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                msj = "Usuario y/o clave incorrectos";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
