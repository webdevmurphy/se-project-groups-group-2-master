using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using group2Project.Views;
namespace group2Project
{
   public class Program
    {   
        [STAThread]
        public static async Task Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread t = new Thread(new ThreadStart(() => 
            {
                try
                {
                    Application.Run(new Views.MainLayout());
                   // mapView map = new mapView();
                   // map.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                   // Application.Run(map);
                   // Application.Run(new Views.ScoreBoard());
                   // Application.Run(new Views.Game());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
