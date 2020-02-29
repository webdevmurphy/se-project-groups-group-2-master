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

namespace group2Project
{
    public partial class CourseGrid : Form
    {
        private CourseList courseList;
        public CourseGrid()
        {
            InitializeComponent();
        }

        private void CoursesLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseGrid_Load(object sender, EventArgs e)
        {
            courseList = new CourseList();
            List<Course> courses = courseList.GetCourses();
            //Clear the list view
            listViewCourses.Items.Clear();
            foreach(var course in courses)
            {
                var row = new string[] { course.name};
                var lvi = new ListViewItem(row);
                //Add the whole object to the Tag property
                // to later display details about the item
                lvi.Tag = course;

                //Add item to list view
                listViewCourses.Items.Add(lvi);
            }

            
        }
    }
}
