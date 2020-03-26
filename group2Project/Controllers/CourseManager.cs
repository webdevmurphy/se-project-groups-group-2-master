using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using group2Project.Models;
using group2Project.CosmosDemo;

namespace group2Project.Controllers
{
    class CourseManager
    {
        //Private list to hold all the courses. Should be pulled from DB
        //Needs to be instantiated at the start of the application.
        private List<Course> courseList;
        private CosmosConnection cosmosDB;

        //Default Constructor
        public CourseManager()
        {
            courseList = new List<Course>();
            InitializeCourseList();
        }

        //Add a course to the list
        public void AddCourse(Course c)
        {
            courseList.Add(c);
        }

        //Delete a course from the list
        public void DeleteCourse(Course c)
        {
            if(courseList.Contains(c))
            {
                courseList.Remove(c);
            }
        }

        //Returns all the courses from the list
        public List<Course> GetCourses()
        {
            return this.courseList;
        }

        //Returns a specific course from the list
        public Course GetCourse(Course c)
        {
            if (courseList.Contains(c))
            {
                int x = courseList.IndexOf(c);
                return courseList[x];
            }
            else return null;
        }

        //Initializes the CourseGrid view with the list of courses
        public async void InitializeCourseList()
        {
            /*
             * 
             * 
             * Need to connect this to database next
             * 
             * 
             */

            //This is purely for testing purposes for getting the courses to display
            //Actual courses will be pulled from the database
            courseList.Add(new Course("Physics", "123"));
            courseList.Add(new Course("History"));
            courseList.Add(new Course("Science"));
            courseList.Add(new Course("English"));
            courseList.Add(new Course("Math"));
            courseList.Add(new Course("Computer Science"));
            Console.WriteLine(courseList);
            for (int i = 0; i < courseList.Count(); i++)
            {
                Console.WriteLine(courseList[i].GetCourseName(), courseList[i].GetID());
             //   await cosmosDB.addCourse(courseList[i].GetCourseName(), courseList[i].GetID());
            }
        }
    }
}
