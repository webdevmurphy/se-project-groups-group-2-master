using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.CosmosDemo;

namespace group2Project.Views
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            Form questionGrid = new questionGrid();
            questionGrid.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Question = QuestionTxtBox.Text;
            string Answer = AnserTxtBox.Text;
            string course = "";//not sure what to put here as of yet
            /*CosmosConnection aNew = new CosmosConnection();
            {
                aNew.addTrivia(Question, Answer, course);
            }*/
            QuestionTxtBox.Text = "";
            AnserTxtBox.Text = "";
            MessageBox.Show("Trivia Added");
        }
    }
}
