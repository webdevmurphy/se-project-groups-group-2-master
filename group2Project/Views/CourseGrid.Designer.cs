namespace group2Project
{
    partial class CourseGrid
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
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoursesLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.CoursesLabel.Location = new System.Drawing.Point(305, 9);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(163, 54);
            this.CoursesLabel.TabIndex = 0;
            this.CoursesLabel.Text = "Courses";
            this.CoursesLabel.Click += new System.EventHandler(this.CoursesLabel_Click);
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseBtn.Location = new System.Drawing.Point(651, 398);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(137, 40);
            this.AddCourseBtn.TabIndex = 1;
            this.AddCourseBtn.Text = "Add Course";
            this.AddCourseBtn.UseVisualStyleBackColor = true;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(12, 398);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 40);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CourseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.CoursesLabel);
            this.Name = "CourseGrid";
            this.Text = "CourseGrid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.Button AddCourseBtn;
        private System.Windows.Forms.Button CancelButton;
    }
}