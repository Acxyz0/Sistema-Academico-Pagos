using SistemaAcademicoPagos.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademicoPagos
{
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
            Login login = new Login();
            Application.Run(login);

            Form nextForm = login.NextForm;
            while (nextForm != null)
            {
                Application.Run(nextForm);
                if (nextForm is Login)
                {
                    login = (Login)nextForm;
                    nextForm = login.NextForm;
                }
                else
                {
                    Inicio inicio = (Inicio)nextForm;
                    nextForm = inicio.NextForm;
                }
            }

        }
    }
}
