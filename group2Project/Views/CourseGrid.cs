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
        private CourseManager courseList;
        private ListView listViewCourses;
        public String selectedCourse;
        public CourseGrid()
        {
            listViewCourses = new ListView();
            courseList = new CourseManager();
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            listViewCourses.Dispose();
            this.Close();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            AddACourse createCourse = new AddACourse();
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

            courseList = new CourseManager();
            List<Course> courses = courseList.GetCourses();

            foreach (var course in courses)
            {
                var courseRow = new string[] { course.GetCourseName()};
                var lvi = new ListViewItem(courseRow);
                Console.WriteLine(courseRow);
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


        private void SubmitButton_Click(object sender, EventArgs e)
        {

            selectedCourse = listViewCourses.FocusedItem.Text;
            Console.WriteLine(selectedCourse);
            this.Close();
            //save the state of courses and return to the previous form
        }

        public string SelectedCourses()
        {
            return selectedCourse;
            //need to pass this to NewGame.cs
        }
    }
}
