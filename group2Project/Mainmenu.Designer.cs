namespace group2Project
{
    partial class Mainmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuHeaderText = new System.Windows.Forms.TextBox();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.LoadGameBtn = new System.Windows.Forms.Button();
            this.CoursesBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuHeaderText
            // 
            this.MainMenuHeaderText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuHeaderText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuHeaderText.Location = new System.Drawing.Point(162, 19);
            this.MainMenuHeaderText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainMenuHeaderText.Name = "MainMenuHeaderText";
            this.MainMenuHeaderText.ReadOnly = true;
            this.MainMenuHeaderText.Size = new System.Drawing.Size(663, 73);
            this.MainMenuHeaderText.TabIndex = 5;
            this.MainMenuHeaderText.Text = "Main Menu";
            this.MainMenuHeaderText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(378, 147);
            this.NewGameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(206, 92);
            this.NewGameBtn.TabIndex = 6;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            // 
            // LoadGameBtn
            // 
            this.LoadGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGameBtn.Location = new System.Drawing.Point(378, 271);
            this.LoadGameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadGameBtn.Name = "LoadGameBtn";
            this.LoadGameBtn.Size = new System.Drawing.Size(206, 92);
            this.LoadGameBtn.TabIndex = 7;
            this.LoadGameBtn.Text = "Load Game";
            this.LoadGameBtn.UseVisualStyleBackColor = true;
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesBtn.Location = new System.Drawing.Point(378, 401);
            this.CoursesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Size = new System.Drawing.Size(206, 92);
            this.CoursesBtn.TabIndex = 8;
            this.CoursesBtn.Text = "Courses";
            this.CoursesBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(378, 543);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(206, 92);
            this.LogoutBtn.TabIndex = 9;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 92);
            this.button1.TabIndex = 10;
            this.button1.Text = "How to Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CoursesBtn);
            this.Controls.Add(this.LoadGameBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.MainMenuHeaderText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mainmenu";
            this.Text = "Mainmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainMenuHeaderText;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button LoadGameBtn;
        private System.Windows.Forms.Button CoursesBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button button1;
    }
}