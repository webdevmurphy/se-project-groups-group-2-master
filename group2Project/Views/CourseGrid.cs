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
    public partial class CourseGrid : Form
    {
        public NewGame newGame;
        public List<Courses> courses;
        public string courseLabel;
        public Courses selectedCourse;

        public CourseGrid() //our default constructor
        {
            InitializeComponent();         
        }

        public CourseGrid(NewGame newGame) //used for when accessing the courses from the newGame screen
        {
            this.newGame = newGame;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void CourseGrid_Load(object sender, EventArgs e)
        {
            listViewCourses.Items.Clear();
            listViewCourses.Columns.Add("Course Name", 500, HorizontalAlignment.Center);
            listViewCourses.LabelEdit = true;
            listViewCourses.GridLines = true;
            listViewCourses.View = View.Details;
            listViewCourses.AllowColumnReorder = true;
            listViewCourses.CheckBoxes = true;
            listViewCourses.MultiSelect = false;

            CourseGridHelper.LoadHelper(this);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            CourseGridHelper.Submit(this);
            this.Close();      
        }

        private ListViewItem lastItemChecked;
        private void listViewCourses_ItemCheck1(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastItemChecked != null && lastItemChecked.Checked
                && lastItemChecked != listViewCourses.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastItemChecked.Checked = false;
            }

            // store current item
            CoursesLabel.Text = listViewCourses.Items[e.Index].Text;        
            lastItemChecked = listViewCourses.Items[e.Index];

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].CourseName == CoursesLabel.Text)
                {
                    selectedCourse = courses[i];
                    Console.WriteLine("Selected Course: " + courses[i].CourseName);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void listViewCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
