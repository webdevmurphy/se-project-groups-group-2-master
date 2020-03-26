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

namespace group2Project.Views
{
    public partial class NewGame : Form
    {
        private int numPlayers;

        public NewGame()
        {
            InitializeComponent();
        }

        private void NewGame_Load_1(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            /*
             * Start game and show map
             */
            mapView map = new mapView();
            map.Show();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        private void button1_Click(object sender, EventArgs e)
        {
            String Course;
            // Form CourseGrid = new CourseGrid();
            CourseGrid example = new CourseGrid();
            example.Show();
            //should talk about which of these is the best way to access CourseGrid and any functions in it
            Course = example.SelectedCourses(); //we need to pass the selected course from courseGrid to the listbox on this newGame form. I'm not really sure how to do it yet
            
        }

        private void NumberOfPlayersTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NewGame_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("hey");
        }
    }
}
