using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group2Project.Views
{
    public partial class questionGrid : Form
    {
        public questionGrid()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Form UpdateQuestion = new UpdateQuestion();
            UpdateQuestion.Show();
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
    }
}
