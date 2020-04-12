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

namespace group2Project.Views
{
    public partial class NewGame : Form
    {
        private int numPlayers;
        private Course course;
        public NewGame()
        {
            course = new Course();
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
            if(courseLabel.Text == null)
            {
                courseLabel.Text = "No Course Selected";
            }
            courseLabel.Text = course.GetCourseName();
            this.Update();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            /*
             * Start game and show map
             */
           // this.Hide();
            mapView map = new mapView(numPlayers, course.GetCourseName()) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.NewGamePanel.Size = new Size(800, 600);
            this.NewGamePanel.Controls.Add(map);
            map.Show();
            
            // this.Show();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            /*this.DialogResult = DialogResult.OK;*/
        }

        
        private void ChooseCourseBtnClk(object sender, EventArgs e)
        {
            var example = new CourseGrid(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            if (!this.Parent.Controls.Contains(example))
            {
                this.NewGamePanel.Controls.Add(example);
                example.Show();
            }
                

            //L@@K @ ME  --Mike: Had to comment this out to get the coursegrid to display in our UI not sure what it does. If its broke, srry >.<
           // this.Show();
            //this.Update();
            
        }

        private void NumberOfPlayersTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(NumberOfPlayersTextBox.Text, "[^0-9]")) {
                MessageBox.Show("Please enter only numbers.");
                NumberOfPlayersTextBox.Text = "";
            }
            numPlayers = Int32.Parse(NumberOfPlayersTextBox.Text);
        }

        private void NewGame_Enter(object sender, EventArgs e)
        { 
            Console.WriteLine("hey");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
           /* this.Close();*/
        }

        private void courseLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
