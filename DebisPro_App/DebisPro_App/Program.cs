﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebisPro_App.Vista;

namespace DebisPro_App
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevisPro sp = new DevisPro();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
            
        }
    }
}
