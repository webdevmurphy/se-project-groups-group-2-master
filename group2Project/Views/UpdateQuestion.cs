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
    public partial class UpdateQuestion : Form
    {
        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        public UpdateQuestion(string question, string answer1)
        {
            InitializeComponent();
            this.question = question;
            this.answer1 = answer1;
        }

        public UpdateQuestion(string question, string answer1, string answer2, string answer3, string answer4)
        {
            InitializeComponent();
            this.question = question;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.answer4 = answer4;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateQuestion_Shown(object sender, EventArgs e)
        {
            Questiontxt.Text = question;
            Answertxt.Text = answer1;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            question = Questiontxt.Text;
            answer1 = Answertxt.Text;
            Close();
        }

        public string ReturnQuestion()
        {
            return question;
        }
        
        public string ReturnAnswer()
        {
            return answer1;
        }
    }
}
