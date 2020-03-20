﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.Models;
using group2Project.CosmosDemo;

namespace group2Project.Views
{
    public partial class CreateCourse : Form
    {
        Course course;
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = sender.ToString();
            course = new Course(name);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string courseName;
            courseName = textBox1.Text;
            textBox1.Text = "";
            CosmosConnection aNew = new CosmosConnection();
            {
                aNew.addCourse(courseName);
            }
            MessageBox.Show("Course added");
        }
    }
}
