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
        public string question;
        public string answer;
        public UpdateQuestion(string question, string answer)
        {
            InitializeComponent();
            this.question = question;
            this.answer = answer;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateQuestion_Shown(object sender, EventArgs e)
        {
            Questiontxt.Text = question;
            Answertxt.Text = answer;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            question = Questiontxt.Text;
            answer = Answertxt.Text;
            Close();
        }

        public string ReturnQuestion()
        {
            return question;
        }
        
        public string ReturnAnswer()
        {
            return answer;
        }
    }
}
