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
        private Label SelectedCourseLabel;

        public NewGame()
        {
            course = new Course();
            SelectedCourseLabel = new Label();
            InitializeComponent();
        }

        private void NewGame_Load_1(object sender, EventArgs e)
        {
            this.Update();
            SelectedCourseLabel.Text = course.GetCourseName();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            /*
             * Start game and show map
             */
            this.Hide();
            mapView map = new mapView(numPlayers, course.GetCourseName());
            map.ShowDialog();
            this.Show();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ChooseCourseBtnClk(object sender, EventArgs e)
        {
            // Form CourseGrid = new CourseGrid();
            this.Hide();
            CourseGrid example = new CourseGrid();
            example.ShowDialog();
            this.Show();
            
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

    }
}
