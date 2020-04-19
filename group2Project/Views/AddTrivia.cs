using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;

using group2Project.DataConnection;
using group2Project.Models;

namespace group2Project.Views
{
    public partial class AddTrivia : Form
    {
        public static IList<string> CourseOfferings = new List<string>();
        public static IList<string> CourseQuestions = new List<string>();
        CheckBox lastChecked;
        Boolean checkedBox = false;
        int answerNum;
        public AddTrivia()
        {
            InitializeComponent();
        }

        private void AddTrivia_Load(object sender, EventArgs e)
        {
            MongoClientConn database = new MongoClientConn("Courses");
            List<Courses> courses = database.GetAll<Courses>("Courses");
            for (int i = 0; i < courses.Count(); i++)
            {
                if(CoursesList.Items.Contains(courses[i].CourseName))
                {
                    Console.WriteLine("Preventing duplicates. ");
                } else
                CoursesList.Items.Add(courses[i].CourseName);
            }
        }

        //Add the course to the List
        private void AddCourse_Click(object sender, EventArgs e)
        {

            if (AddCourseBox.Text == null || AddCourseBox.Text == "")
            {
                MessageBox.Show("Must input some text, and Item must not exist");
            }
            else
            {

                MongoClientConn database = new MongoClientConn("Courses");
                Courses newCourse = new Courses
                {
                    CourseName = AddCourseBox.Text
                };


                database.InsertRecord("Courses", newCourse);

                CoursesList.Items.Add(AddCourseBox.Text);

                CourseOfferings.Add(AddCourseBox.Text);
                AddCourseBox.Clear();

                Console.WriteLine("RESULTS OF BASIC SHIT");
                foreach (string results in CoursesList.Items)
                    Console.WriteLine(results);

                Console.WriteLine("CourseOfferings List type return @@@@@@@@@############@@@@@@@");

                foreach (string results in CourseOfferings)
                    Console.WriteLine(results);
            }
        }

        private void Selection_Click(object sender, EventArgs e)
        {
            string courseName = "";

            SelectedCourseBox.Items.Clear();
            foreach (string result in CoursesList.CheckedItems)
            {

                SelectedCourseBox.Items.Add(result);
                courseName = result.ToString();
                Console.WriteLine("here is my name Biiitch");
                Console.WriteLine(courseName);
            }

            dataGridView1.Rows.Clear();

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
                    dataGridView1.Rows.Add(Row2);
                }

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           /* MongoClientConn database = new MongoClientConn("Courses");
            var recs = database.LoadRecords<Courses>("Courses");
            string courseName = "";
            SelectedCourseBox.Items.Clear();
            foreach (string result in CoursesList.CheckedItems)
            {

                SelectedCourseBox.Items.Add(result);
                courseName = result.ToString();
            }
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
                    dataGridView1.Rows.Add(Row2);
                }

            }*/
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            //make listbox selected item be selected for database if user does not click
            SelectedCourseBox.SelectedIndex = 0;

            Console.WriteLine(SelectedCourseBox.SelectedIndex.ToString());

            //Set the answer to the selected CheckedBox 
            if (checkBox1.Checked)
            {
                answerNum = 1;
            }
            if (checkBox2.Checked)
            {
                answerNum = 2;
            }
            if (checkBox3.Checked)
            {
                answerNum = 3;
            }
            if (checkBox4.Checked)
            {
                answerNum = 4;
            }


            //clear the datagridview
            dataGridView1.Rows.Clear();

            //Make sure all textboxes contain information
            if (QuestionBox.Text != null && QuestionBox.Text != ""
               && Answer1Box.Text != null && Answer1Box.Text != ""
                && Answer2Box.Text != null && Answer2Box.Text != ""
                && Answer3Box.Text != null && Answer3Box.Text != ""
                && Answer4Box.Text != null && Answer4Box.Text != ""
                && checkedBox != false)
            {
                //OPEN a connection to MongoDB, se
                MongoClientConn database = new MongoClientConn("Courses");

                //Set values for the Model
                Courses newCourse = new Courses
                {
                    CourseName = SelectedCourseBox.SelectedItem.ToString(),
                    courseQuestions = new Trivia
                    {
                        Question = QuestionBox.Text,
                        Answer1 = Answer1Box.Text,
                        Answer2 = Answer2Box.Text,
                        Answer3 = Answer3Box.Text,
                        Answer4 = Answer4Box.Text,
                        selAnswer = answerNum,
                        isAnswer = checkedBox
                    }
                };

                //Local form Variables
                string thisQuestion = QuestionBox.Text;
                string Answer1 = Answer1Box.Text;
                string Answer2 = Answer2Box.Text;
                string Answer3 = Answer3Box.Text;
                string Answer4 = Answer4Box.Text;
                int selAnswer = answerNum;
                Boolean isAnswer = checkedBox;

                //Add to the Database
                database.InsertRecord("Courses", newCourse);

                //Verify The selected answer is right on the command Line
                Console.WriteLine("This is Selected Answers Checkmark: ");
                Console.WriteLine(selAnswer);


                //Layout the Datagrid, add the question to the view
                CourseQuestions.Add(thisQuestion);

                var recs = database.LoadRecords<Courses>("Courses");

                foreach (var rec in recs)
                {
                    Console.WriteLine($"{ rec.CourseName}");
                    if (rec.courseQuestions != null && rec.CourseName == SelectedCourseBox.SelectedItem.ToString())
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
                        dataGridView1.Rows.Add(Row2);
                    }

                }

                //Clear textboxes
                QuestionBox.Clear();
                Answer1Box.Clear();
                Answer2Box.Clear();
                Answer3Box.Clear();
                Answer4Box.Clear();

                //Clear checkedBoxes
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

            }
            else
            {
                MessageBox.Show("All Questions Fields must be complete before submission!");
            }
        }

        private void ExitAddCourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            string curItem = CoursesList.SelectedItem.ToString();
            Console.WriteLine("THIS IS CURRENT ITEM");
            Console.WriteLine(curItem);
        }

        private void CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {

            int iSelectedIndex = CoursesList.SelectedIndex;
            //Select Only One Item in the Checkbox Checklist
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < CoursesList.Items.Count; iIndex++)
                CoursesList.SetItemCheckState(iIndex, CheckState.Unchecked);
            CoursesList.SetItemCheckState(iSelectedIndex, CheckState.Checked);

        }

        private void AddCourseBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            this.checkedBox = true;
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox != lastChecked && lastChecked != null) checkedBox = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedBox = true;
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox != lastChecked && lastChecked != null) checkedBox = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedBox = true;
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox != lastChecked && lastChecked != null) checkedBox = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.checkedBox = true;
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox != lastChecked && lastChecked != null) checkedBox = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void QuestionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
