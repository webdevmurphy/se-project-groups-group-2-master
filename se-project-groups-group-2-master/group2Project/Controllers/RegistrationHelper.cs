using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.Models;
using group2Project.Views;
using group2Project.DataConnection;

namespace group2Project.Controllers
{
    class RegistrationHelper
    {
        public static bool Register(Register register, ref string message)
        {
            Boolean isGood = false;
            string dummy = register.EmailBox.Text;
            //Check email for vaild address
            if (dummy == null || dummy == "")
            {
                message = "All Fields Must be Completed, and Passwords must match";
                return false;
            }
            else
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(register.EmailBox.Text);
                    isGood = true;
                }
                catch (FormatException ex)
                {
                    message = "All Fields Must be Completed, and Passwords must match";
                    return false;
                }

            }
            //Check for blank textBoxes
            if (register.EmailBox.Text == "" || register.firstNameBox.Text == "" || register.LastNameBox1.Text == "" || register.passBox.Text == "" || register.TeacherCodeBox.Text == "" || register.PasswordBox2.Text == "" || register.UserNameLabel.Text == "" && register.passBox.ToString().Length != register.PasswordBox2.ToString().Length)
            {

                message = "All Fields Must be Completed, and Passwords must match";
                return false;
            }

            //if its good, create a new student from textbox inputs
            else
            {
                MongoClientConn database = new MongoClientConn("Student");

                Student newStudent = new Student
                {
                    Email = register.EmailBox.Text,
                    FirstName = register.firstNameBox.Text,
                    LastName = register.LastNameBox1.Text,
                    UserName = register.UserNameBox.Text,
                    PassWord = register.passBox.Text,
                    TeacherCode = Convert.ToInt32(register.TeacherCodeBox.Text),
                };

                //Add the new student record into the database
                database.InsertRecord("Student", newStudent);
                //return true then restart.
                message = "Successfully Registered";
                return true;
            }
        }
    }
}
