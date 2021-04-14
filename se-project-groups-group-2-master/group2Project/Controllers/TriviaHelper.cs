using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.DataConnection;
using group2Project.Models;
using group2Project.Views;

namespace group2Project.Controllers
{

    class TriviaHelper
    {
        public static Boolean AddCourse(AddTrivia trivia, ref string message)
        {
            MongoClientConn database = new MongoClientConn("Courses");

            if (trivia.AddCourseBox.Text == null || trivia.AddCourseBox.Text == "")
            {
                message = "Must input some text, and Item must not exist";
                return false;
            }
            else
            {
                Courses newCourse = new Courses
                {
                    CourseName = trivia.AddCourseBox.Text
                };


                database.InsertRecord("Courses", newCourse);

                if (trivia.CoursesList.Items.Contains(newCourse.CourseName))
                {
                    //checkedListBox1.Items.Remove(newCourse.CourseName)
                }
                else
                {
                    trivia.CoursesList.Items.Add(newCourse.CourseName);
                }
                trivia.AddCourseBox.Clear();
                return true;
            }
        }

        public static void SelectCourse(AddTrivia trivia)
        {
            string courseName = "";

            trivia.SelectedCourseBox.Items.Clear();
            foreach (string result in trivia.CoursesList.CheckedItems)
            {

                trivia.SelectedCourseBox.Items.Add(result);
                courseName = result.ToString();
                Console.WriteLine("CourseName: ");
                Console.WriteLine(courseName);
            }

            trivia.dataGridView1.Rows.Clear();

            MongoClientConn database = new MongoClientConn("Courses");

            var recs = database.LoadRecords<Courses>("Courses");
            Console.WriteLine(recs);
            foreach (var rec in recs)
            {
                Console.WriteLine($"{ rec.CourseName}");
                if (rec.courseQuestions != null && rec.CourseName == courseName)
                {
                    courseName = rec.CourseName;
                    string thisQuestion = rec.courseQuestions.Question;
                    string Answer1 = rec.courseQuestions.Answer1;
                    string Answer2 = rec.courseQuestions.Answer2;
                    string Answer3 = rec.courseQuestions.Answer3;
                    string Answer4 = rec.courseQuestions.Answer4;
                    int selAnswer = rec.courseQuestions.selAnswer;

                    string[] Row2 = new[] { courseName, thisQuestion, Answer1, Answer2, Answer3, Answer4, selAnswer.ToString() };

                    Console.WriteLine(rec.courseQuestions.Answer1 + " : " + rec.courseQuestions.Answer2);
                    trivia.dataGridView1.Rows.Add(Row2);
                }

            }
        }

        public static Boolean DeleteCourse(AddTrivia trivia, ref string message)
        {
            Console.WriteLine("Hello ");
            Console.WriteLine(trivia.CoursesList.SelectedIndex.ToString());
            MongoClientConn database = new MongoClientConn("Courses");
            var records = database.LoadRecords<Courses>("Courses");
            foreach (var result in records)
            {
                Console.WriteLine("Course ID: " + result.Id);
                Console.WriteLine("Course Name: " + result.CourseName);
                if (result.CourseName.ToString() == trivia.CoursesList.SelectedItem.ToString() && result.CourseName != null)
                {
                    message = "Deleted! " + "\n" + "Result ID: " + result.Id.ToString() + "\n" + "Course Name: " + result.CourseName + "\n" + "All Records Deleted, Course Removed.";
                    database.DeleteRecord<Courses>("Courses", result.Id);
                    trivia.dataGridView1.Rows.Clear();
                }
            }
            //Remove the item from displayed listboxes
            trivia.SelectedCourseBox.Items.Clear();
            trivia.CoursesList.Items.Remove(trivia.CoursesList.SelectedItem.ToString());
            return true;
        }

        public static Boolean AddQuestion(AddTrivia trivia, ref string message)
        {
            //make listbox selected item be selected for database if user does not click
            trivia.SelectedCourseBox.SelectedIndex = 0;

            Console.WriteLine(trivia.SelectedCourseBox.SelectedIndex.ToString());

            //Set the answer to the selected CheckedBox 
            if (trivia.checkBox1.Checked)
            {
                trivia.answerNum = 1;
            }
            if (trivia.checkBox2.Checked)
            {
                trivia.answerNum = 2;
            }
            if (trivia.checkBox3.Checked)
            {
                trivia.answerNum = 3;
            }
            if (trivia.checkBox4.Checked)
            {
                trivia.answerNum = 4;
            }


            //clear the datagridview
            trivia.dataGridView1.Rows.Clear();

            //Make sure all textboxes contain information
            if (trivia.QuestionBox.Text != null && trivia.QuestionBox.Text != ""
               && trivia.Answer1Box.Text != null && trivia.Answer1Box.Text != ""
                && trivia.Answer2Box.Text != null && trivia.Answer2Box.Text != ""
                && trivia.Answer3Box.Text != null && trivia.Answer3Box.Text != ""
                && trivia.Answer4Box.Text != null && trivia.Answer4Box.Text != ""
                && trivia.checkedBox != false)
            {
                //OPEN a connection to MongoDB, se
                MongoClientConn database = new MongoClientConn("Courses");

                //Set values for the Model
                Courses newCourse = new Courses
                {
                    CourseName = trivia.SelectedCourseBox.SelectedItem.ToString(),
                    courseQuestions = new Trivia
                    {
                        Question = trivia.QuestionBox.Text,
                        Answer1 = trivia.Answer1Box.Text,
                        Answer2 = trivia.Answer2Box.Text,
                        Answer3 = trivia.Answer3Box.Text,
                        Answer4 = trivia.Answer4Box.Text,
                        selAnswer = trivia.answerNum,
                        isAnswer = trivia.checkedBox
                    }
                };

                //Local form Variables
                string thisQuestion = trivia.QuestionBox.Text;
                string Answer1 = trivia.Answer1Box.Text;
                string Answer2 = trivia.Answer2Box.Text;
                string Answer3 = trivia.Answer3Box.Text;
                string Answer4 = trivia.Answer4Box.Text;
                int selAnswer = trivia.answerNum;
                Boolean isAnswer = trivia.checkedBox;

                //Add to the Database
                database.InsertRecord("Courses", newCourse);

                //Verify The selected answer is right on the command Line
                Console.WriteLine("This is Selected Answers Checkmark: ");
                Console.WriteLine(selAnswer);


                //Layout the Datagrid, add the question to the view
                AddTrivia.CourseQuestions.Add(thisQuestion);

                var recs = database.LoadRecords<Courses>("Courses");

                foreach (var rec in recs)
                {
                    Console.WriteLine($"{ rec.CourseName}");
                    if (rec.courseQuestions != null && rec.CourseName == trivia.SelectedCourseBox.SelectedItem.ToString())
                    {
                        string courseName = rec.CourseName;
                        thisQuestion = rec.courseQuestions.Question;
                        Answer1 = rec.courseQuestions.Answer1;
                        Answer2 = rec.courseQuestions.Answer2;
                        Answer3 = rec.courseQuestions.Answer3;
                        Answer4 = rec.courseQuestions.Answer4;
                        selAnswer = rec.courseQuestions.selAnswer;

                        string[] Row2 = new[] { courseName, thisQuestion, Answer1, Answer2, Answer3, Answer4, selAnswer.ToString() };

                        Console.WriteLine(rec.courseQuestions.Answer1 + " : " + rec.courseQuestions.Answer2);
                        trivia.dataGridView1.Rows.Add(Row2);
                    }
                }

                //Clear textboxes
                trivia.QuestionBox.Clear();
                trivia.Answer1Box.Clear();
                trivia.Answer2Box.Clear();
                trivia.Answer3Box.Clear();
                trivia.Answer4Box.Clear();

                //Clear checkedBoxes
                trivia.checkBox1.Checked = false;
                trivia.checkBox2.Checked = false;
                trivia.checkBox3.Checked = false;
                trivia.checkBox4.Checked = false;
                
                return true;
            }
            else
            {
                message = "All Questions Fields must be complete before submission!";
                return false;
            }
        }
    }
}
