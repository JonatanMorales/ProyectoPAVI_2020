using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Proyecto_Bugs_Extendido.Negocio;

namespace Proyecto_Bugs_Extendido
{
    public partial class frmLogin : Form
    {
        Usuarios user = new Usuarios();
        public frmLogin()
        {
            InitializeComponent();
        }
        internal Usuarios User { get => user; set => user = value; }

        //Codigo para poder arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe Ingresar Usuario!");
                this.txtUsuario.Focus();
                return;

            }
            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Debe Ingresar su clave!");
                this.txtContraseña.Focus();
                return;
            }

            //validar usuario y clave
            User.Usuario = txtUsuario.Text;
            User.Password= txtContraseña.Text;


            User.Id_usuario = User.validarUsuario(User.Usuario, User.Password);


            String msj = "";
            if (User.Id_usuario != 0)
            {
                msj = "Login OK!";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                msj = "Usuario y/o Password incorrectos";
                MessageBox.Show(msj, "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContraseña.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
