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
        private NewGame newGame;

        private ListView listViewCourses;
        private List<Course> courses;
        private CourseManager courseManager;
        private questionGrid questionGrid;
        private String selectedCourse;

        CheckBox lastChecked;
        public CourseGrid()
        {           
            courseManager = new CourseManager();
            listViewCourses = new ListView();
            courses = CourseManager.GetCourses();
            lastChecked = new CheckBox();
            InitializeComponent();         
        }

        public CourseGrid(NewGame newGame)
        {
            this.newGame = newGame;
            courseManager = new CourseManager();
            listViewCourses = new ListView();
            courses = CourseManager.GetCourses();
            lastChecked = new CheckBox();
            InitializeComponent();
        }

        public CourseGrid(questionGrid qGrid)
        {
            this.questionGrid = qGrid;
            courseManager = new CourseManager();
            listViewCourses = new ListView();
            courses = CourseManager.GetCourses();
            lastChecked = new CheckBox();
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            listViewCourses.Dispose();
            this.DialogResult = DialogResult.OK;
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddACourse createCourse = new AddACourse(this);
            createCourse.ShowDialog();
            this.Show();
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

        public void UpdateCourses()
        {
            listViewCourses.Items.Clear();
            foreach (var course in courses)
            {
                var courseRow = new string[] { course.GetCourseName() };
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
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {

            selectedCourse = listViewCourses.FocusedItem.Text;
            List<Course> courses = CourseManager.GetCourses();
            for (int i = 0; i < courses.Count(); i++)
            {
                if (selectedCourse == courses[i].GetCourseName())
                {
                    courses[i].SetIsSelected(true);
                    break;
                }
                if (newGame != null)
                {
                    newGame.UpdateCourse(courses[i]);
                    break;
                }
                else
                {
                    questionGrid = new questionGrid(this);
                    questionGrid.Show();
                    break;
                }
            }
            //I'm not sure this is working correctly, currently loops through all the courses and sets the label to each one if you look in code. eventually sets to null 


            Console.WriteLine(selectedCourse);
            this.Close();
            //save the state of courses and return to the previous form
        }

        public string SelectedCourses()
        {
            return selectedCourse;
            //need to pass this to NewGame.cs
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
            lastItemChecked = listViewCourses.Items[e.Index];
        }

/*        private void listViewCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            foreach (var course in courses)
            {
                var courseRow = new string[] { course.GetCourseName() };
                var lvi = new ListViewItem(courseRow);
                Boolean currentCheck = lvi.Checked;
                Boolean newCheck;
                if(currentCheck)
                {
                    lvi.Checked = false;
                }
            }
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }*/
    }
}
