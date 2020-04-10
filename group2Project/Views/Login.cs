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
using group2Project.Models;
using group2Project.Controllers;

namespace group2Project.Views
{
    public partial class Login : Form
    {
        private AccountManager AC;
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
            CreateNewAccount newUser = new CreateNewAccount();
            newUser.Location = this.Location;
            newUser.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;
            Console.WriteLine(username);
            Console.WriteLine(password);

            var user = new User(username, password, 0);
            var AC = new AccountManager(user);
            


            if (AC.Login(username, password))
            {
                Console.WriteLine("LOGIN SUCCESSFUL");
            } else
            {
                Console.WriteLine("LOGIN FAILED");
            }

            this.Hide();
            MainMenu menu1 = new MainMenu();
            menu1.Location = this.Location;
            menu1.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
