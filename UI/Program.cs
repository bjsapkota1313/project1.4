using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    internal static class Program
    {
        ///  The main entry point for the application.
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             //Application.Run(new OrderForm());  
          Application.Run(new Tip(1,2));
            // Application.Run(new TableView());

            // Application.Run(new LoginForm());
          //Application.Run(new LoginForm());
        }
    }
}
