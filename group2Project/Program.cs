using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //Application.Run(new NewGame());
            //Application.Run(new Questions());
            Application.Run(new Login());
        }


       


    }
}
