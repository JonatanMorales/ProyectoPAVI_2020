﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación en lenguajeProgram
        /// </summary>
	/// Punto de conflicto en busqueda
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
