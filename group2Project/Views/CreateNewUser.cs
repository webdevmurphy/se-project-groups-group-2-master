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
    public partial class CreateNewUser : Form
    {
        private String firstName;
        private String lastName;
        private String userName;
        private String phoneNumber;
        private String confirmPassword;
        private String password;


        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox2.Text;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            userName = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             password = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            confirmPassword = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             phoneNumber = textBox6.Text;
        }
    }
}
