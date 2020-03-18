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

namespace group2Project.Views
{
    public partial class CourseGrid : Form
    {
        private CourseList courseList;
        private ListView listViewCourses;
        public CourseGrid()
        {
            listViewCourses = new ListView();
            courseList = new CourseList();
            InitializeComponent();
        }

        private void CoursesLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            listViewCourses.Dispose();
            this.Close();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            CreateCourse createCourse = new CreateCourse();
            createCourse.Show();
        }

        private void CourseGrid_Load(object sender, EventArgs e)
        {

            //Clear the list view initially
            listViewCourses.Items.Clear();
            //Add Columns
            listViewCourses.Columns.Add("Course Name", 500, HorizontalAlignment.Center);
            //Allow user to edit item text
            listViewCourses.LabelEdit = true;
            //Enable Gridlines
            listViewCourses.GridLines = true;
            //Show Details
            listViewCourses.View = View.Details;
            //Allow the user to rearrange columns
            listViewCourses.AllowColumnReorder = true;
            //Display Check Boxes
            listViewCourses.CheckBoxes = true;
            //Allow User to select only one item
            listViewCourses.MultiSelect = false;

            courseList = new CourseList();
            List<Course> courses = courseList.GetCourses();

            foreach (var course in courses)
            {
                var row = new string[] { course.name };
                var lvi = new ListViewItem(row);
                //Add the whole object to the Tag property
                //to later display details about the item
                lvi.Tag = course;
                //Initially box is not checked
                lvi.Checked = false;
                //Add item to list view
                listViewCourses.Items.Add(lvi);
            }

            this.Controls.Add(listViewCourses);

        }

        private void listViewCourses_ItemChecked(Object sender, ItemCheckedEventArgs e)
        {
            foreach (var checkBox in listViewCourses.Items)
            {
                
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
