namespace group2Project
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
            this.CourseBoxLabel = new System.Windows.Forms.Label();
            this.CourseBox = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.NewGameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberOfPlayersLabel
            // 
            this.NumberOfPlayersLabel.AutoSize = true;
            this.NumberOfPlayersLabel.Location = new System.Drawing.Point(137, 92);
            this.NumberOfPlayersLabel.Name = "NumberOfPlayersLabel";
            this.NumberOfPlayersLabel.Size = new System.Drawing.Size(163, 28);
            this.NumberOfPlayersLabel.TabIndex = 0;
            this.NumberOfPlayersLabel.Text = "Enter # of Players";
            // 
            // NumberOfPlayersTextBox
            // 
            this.NumberOfPlayersTextBox.Location = new System.Drawing.Point(352, 92);
            this.NumberOfPlayersTextBox.Name = "NumberOfPlayersTextBox";
            this.NumberOfPlayersTextBox.Size = new System.Drawing.Size(120, 34);
            this.NumberOfPlayersTextBox.TabIndex = 1;
            // 
            // CourseBoxLabel
            // 
            this.CourseBoxLabel.AutoSize = true;
            this.CourseBoxLabel.Location = new System.Drawing.Point(137, 169);
            this.CourseBoxLabel.Name = "CourseBoxLabel";
            this.CourseBoxLabel.Size = new System.Drawing.Size(160, 28);
            this.CourseBoxLabel.TabIndex = 2;
            this.CourseBoxLabel.Text = "Choose A Course";
            // 
            // CourseBox
            // 
            this.CourseBox.FormattingEnabled = true;
            this.CourseBox.ItemHeight = 28;
            this.CourseBox.Location = new System.Drawing.Point(352, 169);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(120, 88);
            this.CourseBox.TabIndex = 3;
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
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(712, 294);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(101, 42);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // NewGameLabel
            // 
            this.NewGameLabel.AutoSize = true;
            this.NewGameLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.NewGameLabel.Location = new System.Drawing.Point(304, 9);
            this.NewGameLabel.Name = "NewGameLabel";
            this.NewGameLabel.Size = new System.Drawing.Size(216, 54);
            this.NewGameLabel.TabIndex = 6;
            this.NewGameLabel.Text = "New Game";
            // 
            // NewGame
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(825, 348);
            this.Controls.Add(this.NewGameLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.CourseBoxLabel);
            this.Controls.Add(this.NumberOfPlayersTextBox);
            this.Controls.Add(this.NumberOfPlayersLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewGame";
            this.Load += new System.EventHandler(this.NewGame_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberOfPlayersLabel;
        private System.Windows.Forms.TextBox NumberOfPlayersTextBox;
        private System.Windows.Forms.Label CourseBoxLabel;
        private System.Windows.Forms.ListBox CourseBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label NewGameLabel;
    }
}