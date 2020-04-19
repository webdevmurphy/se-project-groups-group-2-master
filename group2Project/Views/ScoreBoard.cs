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
    public partial class ScoreBoard : Form
    {
        public int territories { get; set; }
        public int score { get; set; }

        private int seconds;
        private Student student;
        private string userName;
        public ScoreBoard()
        {
            InitializeComponent();
        }

        public ScoreBoard(Student student)
        {
            this.student = student;
            userName = student.UserName;
            score = 0;
            territories = 0;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string[] userNameRow = new string[2];
        string[] territoriesRow = new string[2];
        string[] scoreRow = new string[2];
        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();

            userNameRow[0] = "UserName:";
            userNameRow[1] = userName;

            territoriesRow[0] = "Territories:";
            territoriesRow[1] = territories.ToString();

            scoreRow[0] = "Score:";
            scoreRow[1] = score.ToString();

            var listName = new ListViewItem(userNameRow);
            var listTerritories = new ListViewItem(territoriesRow);
            var listScore = new ListViewItem(scoreRow);
            ScoreBoardList.Items.Add(listName);
            ScoreBoardList.Items.Add(listTerritories);
            ScoreBoardList.Items.Add(listScore);
        }

        public void UpdateList()
        {
            ScoreBoardList.Items.Clear();
            userNameRow[0] = "UserName:";
            userNameRow[1] = userName;

            territoriesRow[0] = "Territories:";
            territoriesRow[1] = territories.ToString();

            scoreRow[0] = "Score:";
            scoreRow[1] = score.ToString();

            var listName = new ListViewItem(userNameRow);
            var listTerritories = new ListViewItem(territoriesRow);
            var listScore = new ListViewItem(scoreRow);
            ScoreBoardList.Items.Add(listName);
            ScoreBoardList.Items.Add(listTerritories);
            ScoreBoardList.Items.Add(listScore);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            score += territories;
            UpdateList();
        }
    }
}
