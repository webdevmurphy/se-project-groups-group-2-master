using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group2Project.Models;

namespace group2Project.Controllers
{
    class CourseList
    {
        private List<Course> courses;

        public CourseList()
        {
            courses = new List<Course>();
            InitializeCourseList();
        }

        public void addCourse(Course c)
        {
            courses.Add(c);
        }

        public void deleteCourse(Course c)
        {
            if(courses.Contains(c))
            {
                courses.Remove(c);
            }
        }

        public List<Course> GetCourses()
        {
            return this.courses;
        }

        public Course getCourse(Course c)
        {
            if (courses.Contains(c))
            {
                int x = courses.IndexOf(c);
                return courses[x];
            }
            else return null;
        }

        public void InitializeCourseList()
        {
            //This is purely for testing purposes for getting the courses to display
            //Actual courses will be pulled from the database
            courses.Add(new Course("Physics"));
            courses.Add(new Course("History"));
            courses.Add(new Course("Science"));
            courses.Add(new Course("English"));
            courses.Add(new Course("Math"));
            courses.Add(new Course("Computer Science"));
        }
    }
}
