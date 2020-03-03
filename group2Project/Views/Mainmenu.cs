using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using group2Project.Views;

namespace group2Project.Views
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            newGame.Show();
        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        {
            CourseGrid courseGrid = new CourseGrid();
            courseGrid.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void MainMenuHeaderText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuHeaderText_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
