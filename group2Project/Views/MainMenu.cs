using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group2Project.Views
{
    class MainMenu : Form
    {
        private Button NewGameBtn;
        private Button LoadGameBtn;
        private Button CoursesBtn;
        private TextBox MainMenuHeaderText;
        private Button LogoutBtn;

        private void InitializeComponent()
        {
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.LoadGameBtn = new System.Windows.Forms.Button();
            this.CoursesBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.MainMenuHeaderText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(242, 134);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(137, 57);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            // 
            // LoadGameBtn
            // 
            this.LoadGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGameBtn.Location = new System.Drawing.Point(242, 197);
            this.LoadGameBtn.Name = "LoadGameBtn";
            this.LoadGameBtn.Size = new System.Drawing.Size(137, 57);
            this.LoadGameBtn.TabIndex = 1;
            this.LoadGameBtn.Text = "Load Game";
            this.LoadGameBtn.UseVisualStyleBackColor = true;
            this.LoadGameBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesBtn.Location = new System.Drawing.Point(242, 260);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Size = new System.Drawing.Size(137, 57);
            this.CoursesBtn.TabIndex = 2;
            this.CoursesBtn.Text = "Courses";
            this.CoursesBtn.UseVisualStyleBackColor = true;
            this.CoursesBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(242, 323);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(137, 57);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenuHeaderText
            // 
            this.MainMenuHeaderText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuHeaderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuHeaderText.Location = new System.Drawing.Point(97, 12);
            this.MainMenuHeaderText.Name = "MainMenuHeaderText";
            this.MainMenuHeaderText.ReadOnly = true;
            this.MainMenuHeaderText.Size = new System.Drawing.Size(442, 73);
            this.MainMenuHeaderText.TabIndex = 4;
            this.MainMenuHeaderText.Text = "Main Menu";
            this.MainMenuHeaderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 420);
            this.Controls.Add(this.MainMenuHeaderText);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CoursesBtn);
            this.Controls.Add(this.LoadGameBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Name = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CourseGrid cg = new CourseGrid();
            cg.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
