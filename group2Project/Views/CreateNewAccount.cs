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
    public partial class CreateNewAccount : Form
    {
        private String firstName;
        private String lastName;
        private String userName;
        private String phoneNumber;
        private String confirmPassword;
        private String password;

        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
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

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Id = lastName + "." + 1;
            Console.WriteLine("Form Input Results" + Id + lastName + firstName + phoneNumber);
            CosmosConnection aNew = new CosmosConnection();
            {
            aNew.addItems(Id, firstName, lastName, userName, password, phoneNumber);
       
            }

            Console.WriteLine("Finished Form Submission");
            this.Hide();
            Login thisPerson = new Login();
            thisPerson.Location = this.Location;
            thisPerson.ShowDialog();

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            userName = textBox3.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
             password = textBox4.Text;
        }

        private void ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            confirmPassword = textBox5.Text;
        }
    }
}
