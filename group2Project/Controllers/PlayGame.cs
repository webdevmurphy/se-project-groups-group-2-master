using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.DataConnection;
using group2Project.Views;
using group2Project.Models;
using System.Windows.Forms;

namespace group2Project.Controllers
{
    class PlayGame
    {
        public static Game Play(Student student)
        {
            List<Courses> courses;
            MongoClientConn database = new MongoClientConn("Courses"); //Create an instance of our DB
            courses = database.GetAll<Courses>("Courses");
            Random rand = new Random();
            Courses course = courses[rand.Next(0, courses.Count)];
            List<Trivia> questions = new List<Trivia>();
            for (int i = 0; i < courses.Count; i++)
            {
                if (String.Equals(courses[i].CourseName, course.CourseName, StringComparison.Ordinal))
                {
                    Console.WriteLine("Question added: " + courses[i].courseQuestions);
                    questions.Add(courses[i].courseQuestions);
                }
            }
            Game game = new Game(1, course, questions, student) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            game.FormBorderStyle = FormBorderStyle.None;
            return game;
        }
    }
}
