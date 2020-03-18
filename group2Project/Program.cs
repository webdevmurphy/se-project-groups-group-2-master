using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using group2Project.Views;



using System.Configuration;
using System.Net;
using Microsoft.Azure.Cosmos;

using group2Project.Models;
using group2Project.CosmosDemo;



namespace group2Project
{
   public class Program
    {
    
        [STAThread]
        public static async Task Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            //Moved Application.run inside of a new thread to fix STA exception error.
            Thread t = new Thread(new ThreadStart(() =>
            {
                try
                {
                    Application.Run(new Login());
                    //Application.Run(new CourseGrid());
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
