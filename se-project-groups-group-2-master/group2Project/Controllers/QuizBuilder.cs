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

        QuizGame quizGame;
        public QuizBuilder(QuizGame quizGame, mapView map, Courses course, List<Trivia> questions, int Index)
        {
            if (questions[Index] == null && questions[Index + 1] == null) //If there are multiple nulls pulled from the DB course is not fully built
            {
                Console.WriteLine("Course is not fully built");
                quizGame.Close();
                quizGame.Dispose();
            }
            else if (questions[Index] == null) //Try the next item in the questions if first object is null. DB initially creates a null object so just add 1 to index.
                                               //Also update the original index passed all the way from mapView
            {
                map.QuestionIndex++;
                currentQuestion = questions[Index + 1];
                selAnswer = currentQuestion.selAnswer;
                Console.Out.WriteLine("Correct Answer: " + selAnswer);
                quizGame.questionLabel.Text = currentQuestion.Question;
                quizGame.button1.Text = currentQuestion.Answer1;
                quizGame.button2.Text = currentQuestion.Answer2;
                quizGame.button3.Text = currentQuestion.Answer3;
                quizGame.button4.Text = currentQuestion.Answer4;
            }
            else
            {
                currentQuestion = questions[Index];
                selAnswer = currentQuestion.selAnswer;
                Console.Out.WriteLine("Correct Answer: " + selAnswer);
                quizGame.questionLabel.Text = currentQuestion.Question;
                quizGame.button1.Text = currentQuestion.Answer1;
                quizGame.button2.Text = currentQuestion.Answer2;
                quizGame.button3.Text = currentQuestion.Answer3;
                quizGame.button4.Text = currentQuestion.Answer4;
            }
            
        }

        public Boolean CheckAnswer(int selectedAnswer)
        {
            Console.Out.WriteLine("Correct Answer: " + selAnswer);
            if (selAnswer == selectedAnswer)
            {
                return true;               
            }
            return false;
        }
    }
}
