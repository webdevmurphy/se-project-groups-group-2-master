using System;

namespace group2Project.Views
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.AutoSize = true;
            this.CoursesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CoursesLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.CoursesLabel.Location = new System.Drawing.Point(333, 9);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(133, 45);
            this.CoursesLabel.TabIndex = 0;
            this.CoursesLabel.Text = "Courses";
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourseBtn.Location = new System.Drawing.Point(667, 261);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(105, 59);
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
            this.listViewCourses.CheckBoxes = true;
            this.listViewCourses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCourses.FullRowSelect = true;
            this.listViewCourses.GridLines = true;
            this.listViewCourses.HideSelection = false;
            this.listViewCourses.Location = new System.Drawing.Point(179, 113);
            this.listViewCourses.MultiSelect = false;
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.RightToLeftLayout = true;
            this.listViewCourses.ShowItemToolTips = true;
            this.listViewCourses.Size = new System.Drawing.Size(465, 368);
            this.listViewCourses.TabIndex = 4;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            this.listViewCourses.SelectedIndexChanged += new System.EventHandler(this.listViewCourses_SelectedIndexChanged);
            //listViewCourses.ItemCheck += new EventHandler(listViewCourses_ItemCheck1);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(667, 523);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(105, 51);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CourseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 585);
            this.Controls.Add(this.SubmitButton);
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button SubmitButton;
    }
}