namespace group2Project.Views
{
    partial class NewGame
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
            this.NumberOfPlayersLabel = new System.Windows.Forms.Label();
            this.NumberOfPlayersTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.NewGameLabel = new System.Windows.Forms.Label();
            this.ChooseCourseBtn = new System.Windows.Forms.Button();
            this.SelectedCourse = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.NewGamePanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOfPlayersLabel
            // 
            this.NumberOfPlayersLabel.AutoSize = true;
            this.NumberOfPlayersLabel.Location = new System.Drawing.Point(246, 33);
            this.NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            this.NumberOfPlayersLabel.Size = new System.Drawing.Size(131, 21);
            this.NumberOfPlayersLabel.TabIndex = 0;
            this.NumberOfPlayersLabel.Text = "Enter # of Players";
            // 
            // NumberOfPlayersTextBox
            // 
            this.NumberOfPlayersTextBox.Location = new System.Drawing.Point(383, 25);
            this.NumberOfPlayersTextBox.Name = "NumberOfPlayersTextBox";
            this.NumberOfPlayersTextBox.Size = new System.Drawing.Size(120, 29);
            this.NumberOfPlayersTextBox.TabIndex = 1;
            this.NumberOfPlayersTextBox.TextChanged += new System.EventHandler(this.NumberOfPlayersTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(12, 294);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 42);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(127, 294);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(101, 42);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NewGameLabel
            // 
            this.NewGameLabel.AutoSize = true;
            this.NewGameLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.NewGameLabel.Location = new System.Drawing.Point(12, 9);
            this.NewGameLabel.Name = "NewGameLabel";
            this.NewGameLabel.Size = new System.Drawing.Size(176, 45);
            this.NewGameLabel.TabIndex = 6;
            this.NewGameLabel.Text = "New Game";
            // 
            // ChooseCourseBtn
            // 
            this.ChooseCourseBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCourseBtn.Location = new System.Drawing.Point(20, 57);
            this.ChooseCourseBtn.Name = "ChooseCourseBtn";
            this.ChooseCourseBtn.Size = new System.Drawing.Size(158, 39);
            this.ChooseCourseBtn.TabIndex = 7;
            this.ChooseCourseBtn.Text = "Choose A Course";
            this.ChooseCourseBtn.UseVisualStyleBackColor = true;
            this.ChooseCourseBtn.Click += new System.EventHandler(this.ChooseCourseBtnClk);
            // 
            // SelectedCourse
            // 
            this.SelectedCourse.AutoSize = true;
            this.SelectedCourse.Location = new System.Drawing.Point(348, 169);
            this.SelectedCourse.Name = "SelectedCourse";
            this.SelectedCourse.Size = new System.Drawing.Size(0, 21);
            this.SelectedCourse.TabIndex = 8;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(32, 117);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(146, 21);
            this.courseLabel.TabIndex = 9;
            this.courseLabel.Text = "No Course Selected";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.courseLabel.Visible = false;
            this.courseLabel.Click += new System.EventHandler(this.courseLabel_Click);
            // 
            // NewGamePanel
            // 
            this.NewGamePanel.Location = new System.Drawing.Point(250, 60);
            this.NewGamePanel.Name = "NewGamePanel";
            this.NewGamePanel.Size = new System.Drawing.Size(486, 336);
            this.NewGamePanel.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::group2Project.Properties.Resources.icons8_close_window_641;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(656, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewGame
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(748, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewGamePanel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.SelectedCourse);
            this.Controls.Add(this.ChooseCourseBtn);
            this.Controls.Add(this.NewGameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NumberOfPlayersTextBox);
            this.Controls.Add(this.NumberOfPlayersLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewGame";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGame_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberOfPlayersLabel;
        private System.Windows.Forms.TextBox NumberOfPlayersTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label NewGameLabel;
        private System.Windows.Forms.Button ChooseCourseBtn;
        private System.Windows.Forms.Label SelectedCourse;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Panel NewGamePanel;
        private System.Windows.Forms.Button button2;
    }
}