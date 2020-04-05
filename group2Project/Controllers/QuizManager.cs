using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using group2Project.Models;

namespace group2Project.Controllers
{
    class QuizManager
    {
        private static Timer aTimer;
        private Quiz quiz;
        private Course c;

        public QuizManager()
        {

        }

        public QuizManager(Quiz q)
        {

        }

        public void StartQuiz()
        {

        }

        public Course GetCourse()
        {
            return c;
        }

        public QuizManager(Course c)
        {
            this.c = c;
        }

        public void SetTimer(Timer timer)
        {
            aTimer = timer;
        }

        public Timer GetTimer()
        {
            return aTimer;
        }
    }
}
