using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.Models;

namespace group2Project.Controllers
{
    class QuestionManager
    {
        //A private list to hold the questions
        private List<Question> questionList;
        
        //Default Constructor
        public QuestionManager() 
        {
            questionList = new List<Question>();
        }

        public QuestionManager(List<Question> questionList)
        {
            this.questionList = questionList;
        }

        //Add question to question list
        public void AddQuestion(Question q)
        {
            questionList.Add(q);
        }

        //Delete question from list
        public void DeleteQuestion(Question q)
        {
            if (questionList.Contains(q))
            {
                questionList.Remove(q);
            }
        }

        //Returns all the questions
        public List<Question> GetQuestions()
        {
            return this.questionList;
        }

        //Returns a specific Question
        public Question GetQuestion(Question q) 
        {
            if (questionList.Contains(q))
            {
                int x = questionList.IndexOf(q);
                return questionList[x];
            }
            else return null;
        }

        //Initializes the questionGrid view with all the questions in the list
        public void InitializeQuestionList()
        {

        }
    }
}

