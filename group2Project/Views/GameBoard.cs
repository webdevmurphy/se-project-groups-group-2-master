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

namespace group2Project.Views
{
    public partial class GameBoard : Form
    {
        int numPlayers;
        Courses course;
        List<Trivia> questions;
        Student student;

        public GameBoard()
        {
            InitializeComponent();
        }

        public GameBoard(int numPlayers, Courses course, List<Trivia> questions, Student student)
        {
            this.student = student;
            this.numPlayers = numPlayers;
            this.course = course;
            this.questions = questions;
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            ScoreBoard scoreBoard = new Views.ScoreBoard(student) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            scoreBoard.FormBorderStyle = FormBorderStyle.None;
            mapView map = new mapView(numPlayers, course, questions, scoreBoard) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            map.FormBorderStyle = FormBorderStyle.None;
            this.ScoreBoardPanel.Controls.Add(scoreBoard);
            this.MapPanel.Controls.Add(map);
            scoreBoard.Show();
            map.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
