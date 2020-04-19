using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.Models;
using group2Project.DataConnection;
using group2Project.Views;

namespace group2Project.Controllers
{
    class QuizBuilder
    {
        public Courses course { get; set; }
        private Trivia currentQuestion;
        private int selAnswer;

        public QuizBuilder(QuizGame quizGame, Courses course, List<Trivia> questions, int Index)
        {
            currentQuestion = questions[Index];
            quizGame.questionLabel.Text = currentQuestion.Question;
            quizGame.button1.Text = currentQuestion.Answer1;
            quizGame.button2.Text = currentQuestion.Answer2;
            quizGame.button3.Text = currentQuestion.Answer3;
            quizGame.button4.Text = currentQuestion.Answer4;
            selAnswer = course.courseQuestions.selAnswer;
        }

        public Boolean CheckAnswer(int selectedAnswer)
        {
            if(selectedAnswer == selAnswer)
            {
                return true;               
            }
            return false;
        }
    }
}
