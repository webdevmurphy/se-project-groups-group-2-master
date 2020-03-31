namespace TriviaNationLayoutDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.NewGameLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CourseBox = new System.Windows.Forms.ListBox();
            this.NumberOfPlayersTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfPlayersLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Choose A Course";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewGameLabel
            // 
            this.NewGameLabel.AutoSize = true;
            this.NewGameLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.NewGameLabel.Location = new System.Drawing.Point(104, 55);
            this.NewGameLabel.Name = "NewGameLabel";
            this.NewGameLabel.Size = new System.Drawing.Size(176, 45);
            this.NewGameLabel.TabIndex = 13;
            this.NewGameLabel.Text = "New Game";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(480, 253);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(101, 42);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(336, 227);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 42);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.Location = new System.Drawing.Point(542, 165);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(120, 82);
            this.CourseBox.TabIndex = 10;
            this.CourseBox.SelectedIndexChanged += new System.EventHandler(this.CourseBox_SelectedIndexChanged);
            // 
            // NumberOfPlayersTextBox
            // 
            this.NumberOfPlayersTextBox.Location = new System.Drawing.Point(419, 120);
            this.NumberOfPlayersTextBox.Name = "NumberOfPlayersTextBox";
            this.NumberOfPlayersTextBox.Size = new System.Drawing.Size(120, 20);
            this.NumberOfPlayersTextBox.TabIndex = 9;
            // 
            // NumberOfPlayersLabel
            // 
            this.NumberOfPlayersLabel.AutoSize = true;
            this.NumberOfPlayersLabel.Location = new System.Drawing.Point(322, 127);
            this.NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            this.NumberOfPlayersLabel.Size = new System.Drawing.Size(91, 13);
            this.NumberOfPlayersLabel.TabIndex = 8;
            this.NumberOfPlayersLabel.Text = "Enter # of Players";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TriviaNationLayoutDemo.Properties.Resources.icons8_close_window_64;
            this.button2.Location = new System.Drawing.Point(723, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 61);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewGameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.NumberOfPlayersTextBox);
            this.Controls.Add(this.NumberOfPlayersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NewGameLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ListBox CourseBox;
        private System.Windows.Forms.TextBox NumberOfPlayersTextBox;
        private System.Windows.Forms.Label NumberOfPlayersLabel;
        private System.Windows.Forms.Button button2;
    }
}