using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.Controllers;
using group2Project.Models;
using group2Project.CosmosDemo;

namespace group2Project.Views
{
    public partial class AddACourse : Form
    {
        private CourseGrid courseGrid;
        Course course;
        CourseManager courseList;


        public AddACourse(CourseGrid courseGrid)
        {
            this.courseGrid = courseGrid;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            CourseManager.AddCourse(new Course(textBox1.Text));
            CourseManager.ShowCourses();
            courseGrid.UpdateCourses();
            textBox1.Text = "";
            MessageBox.Show("Course added");
        }
    }
}
