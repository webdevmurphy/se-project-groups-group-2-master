
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
        CourseGrid courses = new CourseGrid(true) { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        NewGame newPlayer = new NewGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        about about = new about() { Dock = DockStyle.Fill, TopLevel = false, TopMost = false };
        public MainMenu()
        {
            InitializeComponent();
        }

        private void parentContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            if (this.parentContainer.Contains(courses) || this.parentContainer.Contains(about))
            {
                Console.WriteLine("Should no longer open multiple forms");
            }
            else if (!this.parentContainer.Contains(newPlayer))
            {
                this.parentContainer.Controls.Add(newPlayer);
                newPlayer.Show();
            }
        }

        private void loadGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            if(this.parentContainer.Contains(newPlayer) || this.parentContainer.Contains(about))
            {
                Console.WriteLine("Should no longer open multiple forms");
            }
            else if(!this.parentContainer.Contains(courses))
            {
                this.parentContainer.Controls.Add(courses);
                courses.Show();
            }                      
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (this.parentContainer.Contains(newPlayer) || this.parentContainer.Contains(courses))
            {
                Console.WriteLine("Should no longer open multiple forms");
            }
            else if (!this.parentContainer.Contains(about))
            {
                this.parentContainer.Controls.Add(about);
                about.Show();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
﻿}