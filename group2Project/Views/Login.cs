using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.CosmosDemo;

namespace group2Project.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateNewUser newUser = new CreateNewUser();
            newUser.Location = this.Location;
            newUser.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            Console.WriteLine(username);
            string password = textBox2.Text;
            Console.WriteLine(password);

            //test with username: lisa@gmail.com
            //password: 1234
            //and you will see it query the database and return the results.

            CosmosConnection aNew = new CosmosConnection();
            aNew.getPassword( username, password);
            

            Boolean loginInfo = true;

            do
            {
                
                //I wanted this to be noisy, just to make sure the textboxes were getting info, and to watch database output.
                //I removed the database calls from here until I get it working.
           




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("TEXT BOX SUBMISSION");
            Console.WriteLine("*****************************************************");

            Console.WriteLine(username);
            Console.WriteLine(password);

            Console.WriteLine("***END TEXT BOX**************************************");
            Console.WriteLine();
            Console.WriteLine();

             
            

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Username or Password is blank, Please try again.");
                   // loginInfo = false;
                    return;
                }

            } while (loginInfo != true);

            this.Hide();
            Mainmenu menu1 = new Mainmenu();
            menu1.Location = this.Location;
            menu1.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
