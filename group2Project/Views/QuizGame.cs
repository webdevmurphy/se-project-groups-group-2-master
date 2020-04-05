﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using group2Project.Controllers;
using group2Project.Models;

namespace group2Project.Views
{
    public partial class QuizGame : Form
    {
        private Quiz q;
        private Course c;
        private Question currentQuestion;
        private List<Answer> Answers;
        public QuizGame()
        {
            
            InitializeComponent();
        }

        public QuizGame(Question q)
        {
            this.currentQuestion = q;
            InitializeComponent();
        }

        private void QuizGame_Load(object sender, EventArgs e)
        {
            ///////////////PROTOTYPE SETUP//////////////
            ///The basic logic of the quiz game///
            ///Still needs to be broken down and moved into separate modules///
            ///Errors need fixes as well...///
            q = new Quiz(c);
            c = new Course();
            Question question1 = new Question("What is the capital of the United States?");
            question1.addAnswer("New York", false);
            question1.addAnswer("Seattle", false);
            question1.addAnswer("Washington D.C", true);
            question1.addAnswer("Chicago", false);
            c.AddQuestion(question1);
            
            currentQuestion = question1;
            label1.Text = question1.getQuestion();
            if(c.GetQuestions() != null)
            {
                List<Question> list = c.GetQuestions();
                Answers = question1.GetAnswers();
                Console.WriteLine(Answers[0].ToString());
                if(Answers[0] != null)
                {
                    button1.Text = Answers[0].getAnswer();
                }
                if (Answers[1] != null)
                {
                    button2.Text = Answers[1].getAnswer();
                }
                if (Answers[2] != null)
                {
                    button3.Text = Answers[2].getAnswer();
                }
                if (Answers[3] != null)
                {
                    button4.Text = Answers[3].getAnswer();
                }
            } 
            else
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
            }

            /////////////////END PROTOTYPE/////////////////////
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Answers[0].IsCorrect())
            {
                Console.WriteLine("Correct");
            }
            Console.WriteLine("Wrong");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Answers[1].IsCorrect())
            {
                Console.WriteLine("Correct");
            } else
            {
                Console.WriteLine("Wrong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Answers[2].IsCorrect())
            {
                Console.WriteLine("Correct");
            } else
            {
                Console.WriteLine("Wrong");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Answers[3].IsCorrect())
            {
                Console.WriteLine("Correct");
            } else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
