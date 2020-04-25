using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

using group2Project.Models;
using group2Project.DataConnection;
using group2Project.Controllers;

namespace group2Project.Views
{
    public partial class MainLayout : Form
    {
        private Student student;
        private Boolean LoggedIn = false;
        public MainLayout()
        {
            InitializeComponent();          
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string UserName = UserNameBox.Text;
            string password = PasswordBox.Text;

            if (UserName == null || UserName.Equals(""))
            {
                MessageBox.Show("Must enter your credentials!");
            }
            else if (LoginChecker.CheckIfValid(UserName, password, ref student)) //Validate the login
            { 

            LoggedIn = true;
            Console.WriteLine("user is: " + UserName + "\n" + " pass is: " + password);
            WelcomeUser.Text = "Welcome to the Nation, " + UserName + "!";
                UserNameBox.Clear();
                PasswordBox.Clear();         
            } 
            else
            {
                MessageBox.Show("Invalid Login!");
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            Register newRegistration = new Register() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.GamePanel.Controls.Add(newRegistration);
            newRegistration.Show();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            if (LoggedIn == false)
            {
                MessageBox.Show("please log in!");
            }
            else
            {
                BottomMainScreenTable.Hide();
                pictureBox3.Hide();
                NewGame aGame = new NewGame(this, student) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.GamePanel.Controls.Add(aGame);
                aGame.Show();
            }
        }

        private void TeacherMenu_Click(object sender, EventArgs e)
        {
            if (LoggedIn == false)
            {
                MessageBox.Show("please log in!");
            }
            else
            {
                BottomMainScreenTable.Hide();
                pictureBox3.Hide();
                AddTrivia thisTrivia = new AddTrivia() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.GamePanel.Controls.Add(thisTrivia);
                thisTrivia.Show();
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            if (LoggedIn == false)
            {
                MessageBox.Show("please log in!");
            }
            else
            {
                BottomMainScreenTable.Hide();
                pictureBox3.Hide();
                About newAbout = new Views.About() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
                this.GamePanel.Controls.Add(newAbout);
                newAbout.Show();
            }
        }

        private void FutureStuff_Click(object sender, EventArgs e) 
        {
            //Grabs a random course from the DB and starts a new game with 1 player
            /*if (LoggedIn == false)
            {
                MessageBox.Show("please log in!");
            }
            else
            {
                BottomMainScreenTable.Hide();
                pictureBox3.Hide();
                GameBoard game = PlayGame.Play(student);
                this.GamePanel.Controls.Add(game);
                game.Show();
            }*/
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (LoggedIn == false)
            {
                MessageBox.Show("please log in!");
            }
            else
            {
               

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public void AddGame(GameBoard game)
        {
            GamePanel.Controls.Clear();
            GamePanel.Controls.Add(game);
            game.Show();
        }
    }
}
