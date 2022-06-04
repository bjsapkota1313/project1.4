using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            Application.Run(new Order());
=======


            //Application.Run(new KitchenAndBarView());


            // Application.Run(new LoginForm());
            // Application.Run(new TableView());


            Application.Run(new OrderForm());

            // Application.Run(new KitchenAndBarView());

            // Application.Run(new LoginForm());
         // Application.Run(new Payment());

>>>>>>> Stashed changes
        }
    }
}
