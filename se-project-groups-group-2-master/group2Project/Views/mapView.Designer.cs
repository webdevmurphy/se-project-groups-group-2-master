﻿namespace group2Project.Views
{
    partial class mapView
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapView));
            this.picGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // picGrid
            // 
            this.picGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGrid.BackColor = System.Drawing.Color.White;
            this.picGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGrid.BackgroundImage")));
            this.picGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGrid.Location = new System.Drawing.Point(3, 3);
            this.picGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(818, 496);
            this.picGrid.TabIndex = 1;
            this.picGrid.TabStop = false;
            this.picGrid.Click += new System.EventHandler(this.picGrid_Click);
            this.picGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.picGrid_Paint);
            this.picGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picGrid_MouseClick);
            this.picGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picGrid_MouseMove);
            this.picGrid.Resize += new System.EventHandler(this.picGrid_Resize);
            // 
            // mapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(822, 503);
            this.Controls.Add(this.picGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mapView";
            this.Text = "Trivia Nation World Map";
            this.Load += new System.EventHandler(this.mapView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrid;
    }
}
