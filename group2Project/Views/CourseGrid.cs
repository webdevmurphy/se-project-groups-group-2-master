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

            listViewCourses.Items.Clear();
            listViewCourses.Columns.Add("Course Name", 500, HorizontalAlignment.Center);
            listViewCourses.LabelEdit = true;
            listViewCourses.GridLines = true;
            listViewCourses.View = View.Details;
            listViewCourses.AllowColumnReorder = true;
            listViewCourses.CheckBoxes = true;
            listViewCourses.MultiSelect = false;
            foreach (var course in courses)
            {
                var courseRow = new string[] { course.GetCourseName()};
                var lvi = new ListViewItem(courseRow);
                Console.WriteLine(courseRow);
                lvi.Tag = course;
                lvi.Checked = false;
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
                lvi.Tag = course;
                lvi.Checked = false;
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
                    newGame.UpdateCourse(courses[i]);
                    break;
                }
                if (newGame != null)
                {
                    newGame.UpdateCourse(courses[i]);
                    this.Close();
                    break;
                }
                else
                {
                    this.Hide();
                    questionGrid = new questionGrid(this);
                    questionGrid.ShowDialog();
                    this.Show();
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
           CoursesLabel.Text = listViewCourses.Items[e.Index].Text;        
           lastItemChecked = listViewCourses.Items[e.Index];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
