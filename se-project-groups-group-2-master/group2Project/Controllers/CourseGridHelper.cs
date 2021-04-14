using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.Views;
using group2Project.Models;
using group2Project.DataConnection;
using System.Windows.Forms;

namespace group2Project.Controllers
{
    class CourseGridHelper
    {
        List<Courses> courses;
        public static void LoadHelper(CourseGrid courseGrid)
        {
            MongoClientConn database = new MongoClientConn("Courses"); //Create an instance of our DB
            courseGrid.courses = database.GetAll<Courses>("Courses"); //Grab all the courses from the DB
            List<string> duplicateList = new List<string>();
            if (courseGrid.courses != null)
            {
                for (int i = 0; i < courseGrid.courses.Count; i++)
                {
                    Console.WriteLine(courseGrid.courses[i].CourseName);
                    if (duplicateList.Contains(courseGrid.courses[i].CourseName))
                    {
                        Console.WriteLine("Preventing Duplicates");
                    }
                    else
                    {
                        var courseName = new string[] { courseGrid.courses[i].CourseName };
                        var lvi = new ListViewItem(courseName);
                        duplicateList.Add(courseGrid.courses[i].CourseName);
                        lvi.Tag = courseGrid.courses[i];
                        lvi.Checked = false;
                        courseGrid.listViewCourses.Items.Add(lvi);
                    }
                }
            }
            duplicateList.Clear();
            courseGrid.Controls.Add(courseGrid.listViewCourses);
        }

        public static void Submit(CourseGrid courseGrid)
        {
            if (courseGrid.listViewCourses.FocusedItem == null) //Check and see if there is a selected item before setting. If no item selected display an error to the user.
            {
                var result = MessageBox.Show("Please make a selection", "No selection");
            }
            else
            {
                courseGrid.courseLabel = courseGrid.listViewCourses.FocusedItem.Text;
                for (int i = 0; i < courseGrid.courses.Count; i++)
                {
                    if (courseGrid.courses[i].CourseName == courseGrid.courseLabel)
                    {
                        courseGrid.selectedCourse = courseGrid.courses[i];
                        courseGrid.newGame.course = courseGrid.selectedCourse;
                    }
                }
                if (courseGrid.newGame != null) //If we are creating a newGame. Submit button should update the newGame form with the selectedCourse
                {
                    courseGrid.newGame.UpdateCourseLabel(courseGrid.courseLabel);
                }
                Console.WriteLine(courseGrid.courseLabel);
            }
        }
    }
}
