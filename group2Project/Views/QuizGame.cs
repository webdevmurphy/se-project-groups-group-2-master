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
using group2Project.Controllers;

namespace group2Project.Views
{
    public partial class QuizGame : Form
    {
        private List<Trivia> questions;
        private QuizBuilder quizBuilder;
        private Courses course;
        private int seconds;
        private int Index;
        private bool isCorrect = false;
        public QuizGame()
        {
            
            InitializeComponent();
            quizTimer.Start();
        }

        public QuizGame(Courses course, List<Trivia>Questions, int QuestionIndex)
        {
            this.Index = QuestionIndex;
            this.questions = Questions;
            this.course = course;
            InitializeComponent();
        }

        private void QuizGame_Load(object sender, EventArgs e)
        {
            quizTimer.Start();
            quizBuilder = new QuizBuilder(this, course, questions, Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quizBuilder.CheckAnswer(1))
            {
                quizTimer.Stop();
                isCorrect = true;
                var result = MessageBox.Show("Correct!", "Answer Correct");
            }
            else
            {
                quizTimer.Stop();
                var result = MessageBox.Show("Incorrect", "Answer Incorrect");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (quizBuilder.CheckAnswer(2))
            {
                quizTimer.Stop();
                isCorrect = true;
                var result = MessageBox.Show("Correct!", "Answer Correct");
            } 
            else
            {
                quizTimer.Stop();
                var result = MessageBox.Show("Incorrect", "Answer Incorrect");
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quizBuilder.CheckAnswer(3))
            {
                quizTimer.Stop();
                isCorrect = true;
                var result = MessageBox.Show("Correct!", "Answer Correct");
            }
            else
            {
                quizTimer.Stop();
                var result = MessageBox.Show("Incorrect", "Answer Incorrect");
            }
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (quizBuilder.CheckAnswer(4))
            {
                quizTimer.Stop();
                isCorrect = true;
                var result = MessageBox.Show("Correct!", "Answer Correct");
            }
            else
            {
                quizTimer.Stop();
                var result = MessageBox.Show("Incorrect", "Answer Incorrect");
            }
            this.Close();
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            timerLabel.Text = seconds.ToString();
            if (seconds == 30)
            {
                quizTimer.Stop();
                var result = MessageBox.Show("Times Up!", "Time limit reached");
                this.Close();                            
            } 
        }

        public Boolean returnCorrect()
        {
            return isCorrect;
        }
    }
}
