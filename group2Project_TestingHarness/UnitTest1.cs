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
