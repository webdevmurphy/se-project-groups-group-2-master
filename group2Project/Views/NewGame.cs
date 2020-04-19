using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.Models;
using group2Project.DataConnection;

namespace group2Project.Views
{
    public partial class NewGame : Form
    {
        public int numPlayers { get; set; }
        public Courses course;
        private Student student;
        private List<Trivia> questions;
        private List<Courses> courseList;
        private MainLayout main;
        public NewGame(MainLayout main, Student student)
        {
            this.student = student;
            this.main = main;
            questions = new List<Trivia>();
            courseList = new List<Courses>();
            MongoClientConn database = new MongoClientConn("Courses");
            courseList = database.LoadRecords<Courses>("Courses");
            numPlayers = 0;
            InitializeComponent();
        }

        public void UpdateCourseLabel(string courseName)
        {
            courseLabel.Text = courseName;
            if (courseLabel.Text != null)
            {
                courseLabel.Visible = true;
            }
            this.Update();
        }

        private void NewGame_Load_1(object sender, EventArgs e)
        {
            numPlayers = 0;
            courseLabel.Text = "";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            /*
             * Start game and show map
             */
             if(numPlayers <= 0)
            {
                string text = "Please enter the number of players";
                string caption = "No players";
                var result = MessageBox.Show(text, caption);
            } 
            else if(course == null)
            {
                string text = "Please select a course";
                string caption = "No course";
                var result = MessageBox.Show(text, caption);
            } 
            else
            {
                
                for (int i = 0; i < courseList.Count; i++)
                {
                    if (String.Equals(courseList[i].CourseName,course.CourseName,StringComparison.Ordinal))
                    {
                        Console.WriteLine("Question added: " + courseList[i].courseQuestions);
                        questions.Add(courseList[i].courseQuestions);
                    }
                }
                
                
                Game game = new Game(numPlayers, course, questions, student) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                game.FormBorderStyle = FormBorderStyle.None;
                main.AddGame(game);
                // MainLayout.AddGame(game);
                /*game.Show();*/
                /*mapView map = new mapView(numPlayers, course, questions) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.NewGamePanel.Size = new Size(800, 600);
                this.NewGamePanel.Controls.Add(map);
                map.Show();*/
            }          
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        
        private void ChooseCourseBtnClk(object sender, EventArgs e)
        {
            var example = new CourseGrid(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            if (!this.Parent.Controls.Contains(example))
            {
                this.NewGamePanel.Controls.Add(example);
                example.Show();
            }
        }

        private void NumberOfPlayersTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(NumberOfPlayersTextBox.Text, "[^0-9]")) {
                MessageBox.Show("Please enter only numbers.");
                NumberOfPlayersTextBox.Text = "";
            }
            if(NumberOfPlayersTextBox.Text != "")
            {
                numPlayers = Int32.Parse(NumberOfPlayersTextBox.Text);
            }          
        }

        private void courseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
