using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Bugs_Extendido.Negocio;


namespace Proyecto_Bugs_Extendido.Presentacion
{
    public partial class frmPrincipal : Form
    {
        Usuarios usuarioActual;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();

            this.usuarioActual = fl.User;
            if (this.usuarioActual.Id_usuario == 0)
                this.Close();
            else
                this.Text = this.Text + " -Usuario: " + this.usuarioActual.Usuario;

            fl.Dispose();

        }
    }
}
