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

        private bool edit;

        CheckBox lastChecked;
        public CourseGrid() //our default constructor
        {
            edit = false;
            courseManager = new CourseManager();
            listViewCourses = new ListView();
            courses = CourseManager.GetCourses();
            lastChecked = new CheckBox();
            InitializeComponent();         
        }

        public CourseGrid(bool edit) //used for when editing the courses in the MainMenu courses button
        {
            this.edit = edit;
            courseManager = new CourseManager();
            listViewCourses = new ListView();
            courses = CourseManager.GetCourses();
            lastChecked = new CheckBox();
            InitializeComponent();
        }

        public CourseGrid(NewGame newGame) //used for when accessing the courses from the newGame screen
        {
            this.newGame = newGame;
            courseManager = new CourseManager();
            listViewCourses = new ListView();
            courses = CourseManager.GetCourses();
            lastChecked = new CheckBox();
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            /*listViewCourses.Dispose();
            this.DialogResult = DialogResult.OK;*/
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
            if(edit) { SubmitButton.Text = "Edit"; } //if we are editing courses change the button to say Edit instead

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
                Console.WriteLine(courseRow.ToString());
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

        Course course;
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (listViewCourses.FocusedItem == null) //Check and see if there is a selected item before setting. If no item selected display an error to the user.
            {
                var result = MessageBox.Show("Please make a selection", "No selection");
            } 
            else
            {
                selectedCourse = listViewCourses.FocusedItem.Text;
                if (newGame != null) //If we are creating a newGame. Submit button should update the newGame form with the selectedCourse
                {
                    newGame.UpdateCourseLabel(selectedCourse);
                    this.Close();
                }
                else //If we are not creating a new game. Submit button should open the Questions for the checked course.
                {
                    this.Hide();
                    course = (Course)listViewCourses.FocusedItem.Tag;
                    questionGrid = new questionGrid(course);
                    questionGrid.ShowDialog();
                    this.Show();
                }
                Console.WriteLine(selectedCourse);
            }                      
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
            this.Parent.Controls.Remove(this);
            /*this.Close();*/
        }
    }
}
