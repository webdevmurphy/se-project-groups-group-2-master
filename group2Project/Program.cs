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
using group2Project.Controllers;



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
                    //Course c = new Course();
                    //Application.Run(new QuizGame());
                    //Application.Run(new Login());
                    Application.Run(new NewMainMenu());
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
