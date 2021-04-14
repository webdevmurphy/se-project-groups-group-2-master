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
            string test_email = "test@test.com";
            string test_first_name = "first";
            string test_last_name = "last";
            string test_username = "user";
            string test_password = "pass";
            int test_teacher_code = 2;
            Student testStudent = new Student
            {
                Email = "test@test.com",
                FirstName = "first",
                LastName = "last",
                UserName = "user",
                PassWord = "pass",
                TeacherCode = 2
            };
            Assert.AreEqual(test_email, testStudent.Email);
            Assert.AreEqual(test_first_name, testStudent.FirstName);
            Assert.AreEqual(test_last_name, testStudent.LastName);
            Assert.AreEqual(test_username, testStudent.UserName);
            Assert.AreEqual(test_password, testStudent.PassWord);
            Assert.AreEqual(test_teacher_code, testStudent.TeacherCode);
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
    public class Courses_Test 
    {
        [TestMethod]
        public void TestMethod() 
        {
            string course_name_test = "test";
            Courses testCourses = new Courses
            {
                CourseName = "test"
            };
            Assert.AreEqual(course_name_test, testCourses.CourseName);
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
