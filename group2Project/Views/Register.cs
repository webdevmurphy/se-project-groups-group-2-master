using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using group2Project.Models;
using group2Project.DataConnection;
using group2Project.Controllers;

namespace group2Project.Views
{
    public partial class Register : Form
    {
        private Boolean isGood = false;
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check email for vaild address
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(EmailBox.Text);
                isGood = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid email address");

                return;
            }
            //Check for blank textBoxes
            if (EmailBox.Text == "" || firstNameBox.Text == "" || LastNameBox1.Text == "" || passBox.Text == "" || TeacherCodeBox.Text == "" || PasswordBox2.Text == "" || UserNameBox.Text == "" && passBox.ToString().Length != PasswordBox2.ToString().Length )
            {
                
                MessageBox.Show("All Fields Must be Completed, and Passwords must match");
               return;
            }
            
            //if its good, create a new student from textbox inputs
            else
            {
                MongoClientConn database = new MongoClientConn("Student");

                Student newStudent = new Student
                {
                    Email = EmailBox.Text,
                    FirstName = firstNameBox.Text,
                    LastName = LastNameBox1.Text,
                    UserName = textBox1.Text,
                    PassWord = passBox.Text,
                    TeacherCode = Convert.ToInt32(this.TeacherCodeBox.Text),
                };

                //Add the new student record into the database
                database.InsertRecord("Student", newStudent);
                //restart the application so user can login.
                Application.Restart();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacherCode(object sender, KeyEventArgs e)
        {

        }

        private void TeacherCodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
