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
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        private void button1_Click(object sender, EventArgs e)
        {
            Form CourseGrid = new CourseGrid();
            CourseGrid.Show();
        }

        private void NumberOfPlayersTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
