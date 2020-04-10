
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group2Project.Views
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void parentContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            NewGame newPlayer = new NewGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.parentContainer.Controls.Add(newPlayer);
            newPlayer.Show();
        }

        private void loadGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            var courses = new CourseGrid(true) { Dock = DockStyle.Fill, TopLevel = false, TopMost = false  };
            this.parentContainer.Controls.Add(courses);
            courses.Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            var about = new about() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
            this.parentContainer.Controls.Add(about);
            about.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
﻿}