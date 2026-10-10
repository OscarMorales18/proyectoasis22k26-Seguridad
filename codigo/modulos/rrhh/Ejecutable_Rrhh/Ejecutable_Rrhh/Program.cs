using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecutable_Rrhh
{
    internal static class Program
    {
        // Marca la aplicación como compatible con DPI para que Windows no estire
        // (y deje borrosas) las imágenes cuando la pantalla tiene escalado.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CapaVista_Rrhh.Formularios.FrmMDIRrhh());
        }
    }
}
