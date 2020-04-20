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
using group2Project.Controllers;

namespace group2Project.Views
{
    public partial class AddTrivia : Form
    {
        public static IList<string> CourseOfferings = new List<string>();
        public static IList<string> CourseQuestions = new List<string>();
        public CheckBox lastChecked;
        public Boolean checkedBox = false;
        public int answerNum;

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

        //////Logic for buttons below this line moved into TriviaHelper//////
        private void AddCourse_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!TriviaHelper.AddCourse(this, ref message))
            {
                MessageBox.Show(message);
            }
        }

        private void Selection_Click(object sender, EventArgs e)
        {
            TriviaHelper.SelectCourse(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string message = "";
            if (TriviaHelper.DeleteCourse(this, ref message))
            {
                MessageBox.Show(message);
            }
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!TriviaHelper.AddQuestion(this, ref message))
            {
                MessageBox.Show(message);
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
