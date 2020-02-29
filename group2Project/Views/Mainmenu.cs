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

namespace group2Project
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
    }
}
