﻿namespace group2Project.Views
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
            this.components = new System.ComponentModel.Container();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.listViewCourses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoursesLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.CoursesLabel.Location = new System.Drawing.Point(344, 11);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(133, 45);
            this.CoursesLabel.TabIndex = 0;
            this.CoursesLabel.Text = "Courses";
            this.CoursesLabel.Click += new System.EventHandler(this.CoursesLabel_Click);
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseBtn.Location = new System.Drawing.Point(595, 522);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(154, 52);
            this.AddCourseBtn.TabIndex = 1;
            this.AddCourseBtn.Text = "Add Course";
            this.AddCourseBtn.UseVisualStyleBackColor = true;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(14, 522);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(106, 52);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // listViewCourses
            // 
            this.listViewCourses.AllowColumnReorder = true;
            this.listViewCourses.AllowDrop = true;
            this.listViewCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCourses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCourses.FullRowSelect = true;
            this.listViewCourses.GridLines = true;
            this.listViewCourses.HideSelection = false;
            this.listViewCourses.Location = new System.Drawing.Point(69, 126);
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.RightToLeftLayout = true;
            this.listViewCourses.ShowItemToolTips = true;
            this.listViewCourses.Size = new System.Drawing.Size(622, 340);
            this.listViewCourses.TabIndex = 4;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            // 
            // CourseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 585);
            this.Controls.Add(this.listViewCourses);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.CoursesLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CourseGrid";
            this.Text = "Course Grid";
            this.Load += new System.EventHandler(this.CourseGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.Button AddCourseBtn;
        private System.Windows.Forms.Button CancelButton;
        //private System.Windows.Forms.ListView listViewCourses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}