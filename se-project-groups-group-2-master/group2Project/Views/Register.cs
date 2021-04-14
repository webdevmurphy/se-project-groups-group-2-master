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
        private string message = "";
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegistrationHelper.Register(this, ref message))
            {
                MessageBox.Show(message);
                Application.Restart();
            }
            else
            {
                MessageBox.Show(message);
                return;
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
