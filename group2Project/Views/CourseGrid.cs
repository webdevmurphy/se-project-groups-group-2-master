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

namespace group2Project.Views
{
    public partial class CourseGrid : Form
    {
        private NewGame newGame;

        private ListView listViewCourses;
        private List<Courses> courses;
        private string courseLabel;

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
            /*listViewCourses.Dispose();
            this.DialogResult = DialogResult.OK;*/
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

            MongoClientConn database = new MongoClientConn("Courses"); //Create an instance of our DB
            courses = database.GetAll<Courses>("Courses"); //Grab all the courses from the DB
            List<string> duplicateList = new List<string>();
            if (courses != null)
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    Console.WriteLine(courses[i].CourseName);
                    if (duplicateList.Contains(courses[i].CourseName))
                    {
                        Console.WriteLine("Preventing Duplicates");
                    }
                    else
                    {
                        var courseName = new string[] { courses[i].CourseName };
                        var lvi = new ListViewItem(courseName);
                        duplicateList.Add(courses[i].CourseName);
                        lvi.Tag = courses[i];
                        lvi.Checked = false;
                        listViewCourses.Items.Add(lvi);
                    }                 
                }
            }
            duplicateList.Clear();
            this.Controls.Add(listViewCourses);
        }

        Courses selectedCourse;
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (listViewCourses.FocusedItem == null) //Check and see if there is a selected item before setting. If no item selected display an error to the user.
            {
                var result = MessageBox.Show("Please make a selection", "No selection");
            } else
            {
                courseLabel = listViewCourses.FocusedItem.Text;
                for(int i = 0; i < courses.Count; i++)
                {
                    if(courses[i].CourseName == courseLabel)
                    {
                        selectedCourse = courses[i];
                        newGame.course = selectedCourse;
                    }
                }
                if (newGame != null) //If we are creating a newGame. Submit button should update the newGame form with the selectedCourse
                {
                    newGame.UpdateCourseLabel(courseLabel);
                    this.Close();
                }
                Console.WriteLine(courseLabel);
            }        
                               
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

            //grab from database
            MongoClientConn database = new MongoClientConn("Courses");
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
