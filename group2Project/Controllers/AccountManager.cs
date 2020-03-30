using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.Models;
using group2Project.CosmosDemo;

namespace group2Project.Controllers
{
    class AccountManager
    {
        private User user;

        public AccountManager()
        {
            user = new User();
        }

        public AccountManager(User user)
        {
            this.user = user;
        }


        public Boolean Login(string username, string password)
        {
            CosmosConnection aNew = new CosmosConnection(); //establish connection with DB
            aNew.getPassword(username, password);
            Boolean loginInfo = true;
            do
            {
                
                //test with username: lisa@gmail.com
                //password: 1234
                //and you will see it query the database and return the results.
                //I wanted this to be noisy, just to make sure the textboxes were getting info, and to watch database output.
                //I removed the database calls from here until I get it working.
                Console.WriteLine("*****************************************************");
                Console.WriteLine("TEXT BOX SUBMISSION");
                Console.WriteLine("*****************************************************");
                Console.WriteLine(username);
                Console.WriteLine(password);
                Console.WriteLine("***END TEXT BOX**************************************");
            } while (loginInfo != true);
            return true;
        }

        public void createAccount()
        {
            
        }
        
        
    }
}
