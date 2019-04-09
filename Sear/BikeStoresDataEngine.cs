using Sear.it.objectmethod.sear.data.repository.it.objectmethod.sear.userInterface;
using System;
using System.Windows.Forms;

namespace Sear
{
    static class BikeStoresDataEngine
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PreLoginForm());
        }
    }
}
