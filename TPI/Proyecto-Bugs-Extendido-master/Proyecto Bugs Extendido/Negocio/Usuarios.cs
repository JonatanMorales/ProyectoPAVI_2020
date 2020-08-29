using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_Bugs_Extendido.Datos;


namespace Proyecto_Bugs_Extendido.Negocio
{
    class Usuarios
    {
        private int id_usuario;
        private string usuario;
        private string password;
        private string email;
        private string estado;
        private int id_perfil;
        private bool borrado;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }

        public string Estado { get => estado; set => estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }

        public int validarUsuario(string nombre, string clave)
        {
            string consultaSQL = "select * from Usuarios where usuario='" + nombre + "' and password='" + clave + "'";
            DataTable tabla = new DataTable();
            AD_Usuarios oDatos = new AD_Usuarios();
            tabla = oDatos.consultar(consultaSQL);
            if (tabla.Rows.Count > 0)
                return Convert.ToInt32(tabla.Rows[0][0]);
            else
                return 0;

        }

    }
}
