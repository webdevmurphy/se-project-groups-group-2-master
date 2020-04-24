using Microsoft.VisualStudio.TestTools.UnitTesting;
using group2Project;
using group2Project.DataConnection;
using group2Project.Models;
using group2Project.Views;

namespace group2Project_TestingHarness
{

    [TestClass]
    public class Main_Test
    {
        //Test Registration registers a student
        MongoClientConn database = new MongoClientConn("Student");
        [TestMethod]
        public void TestMethod()
        {

        }
    }

    [TestClass]
    public class Student_Test
    {
        [TestMethod]
        public void TestMethod()
        {

        }
    }

    [TestClass]
    public class Trivia_Test
    {
        [TestMethod]
        public void TestMethod()
        {
            int answer = 2;
            string question_1 = "Answer 1";
            string question_2 = "Answer 2";
            string question_3 = "Answer 3";
            string question_4 = "Answer 4";
            Trivia testTrivia = new Trivia
            {
                Question = "Test question",
                Answer1 = "Answer 1",
                Answer2 = "Answer 2",
                Answer3 = "Answer 3",
                Answer4 = "Answer 4",
                isAnswer = true,
                selAnswer = 2
            };
            Assert.AreEqual(answer, testTrivia.selAnswer);
            Assert.AreEqual(question_1, testTrivia.Answer1);
            Assert.AreEqual(question_2, testTrivia.Answer2);
            Assert.AreEqual(question_3, testTrivia.Answer3);
            Assert.AreEqual(question_4, testTrivia.Answer4);
        }
    }

    [TestClass]
    public class LoginChecker_Test
    {
        [TestMethod]
        public void TestMethod()
        {

        }
    }

    [TestClass]
    public class QuizBuilder_Test
    {
        [TestMethod]
        public void TestMethod()
        {

        }
    }

}
