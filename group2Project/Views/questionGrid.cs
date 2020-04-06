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

namespace group2Project.Views
{
    public partial class questionGrid : Form
    {
        private Course c;
        public questionGrid(CourseGrid c)
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateQuestion UpdateTrivia = new UpdateQuestion(QuestionRecords.SelectedRows[0].Cells[0].Value.ToString(), this.QuestionRecords.SelectedRows[0].Cells[1].Value.ToString());
            UpdateTrivia.ShowDialog();
            QuestionRecords.SelectedRows[0].Cells[0].Value =  UpdateTrivia.ReturnQuestion();
            QuestionRecords.SelectedRows[0].Cells[1].Value = UpdateTrivia.ReturnAnswer();
        }

        public void addQuestion(String Question, String Answer)
        {
            QuestionRecords.Rows.Add(new string[] { Question, Answer });
            //need to add course to this as well so that questions can be specifically pulled
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (QuestionRecords.SelectedRows.Count > 0)
            {
                QuestionRecords.Rows.RemoveAt(QuestionRecords.SelectedRows[0].Index);
            }
        }
    }
}
