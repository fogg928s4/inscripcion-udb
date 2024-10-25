using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCatedra
{
    /*Aquí compartimos un usuario de tipo administrador:
     Carnet: 123456
     Contraseña: rene
     Y a continuación un usuario de tipo estudiante:
     carnet: VV981775
     contraseña: vicente
     Si quiere ingresar usuarios distintos revise el script de la base de datos adjuntada con este programa.
     */
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logo());
        }
    }
}
