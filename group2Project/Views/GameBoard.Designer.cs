namespace group2Project.Views
{
    partial class GameBoard
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
            this.ScoreBoardPanel = new System.Windows.Forms.Panel();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreBoardPanel
            // 
            this.ScoreBoardPanel.Location = new System.Drawing.Point(12, 12);
            this.ScoreBoardPanel.Name = "ScoreBoardPanel";
            this.ScoreBoardPanel.Size = new System.Drawing.Size(188, 557);
            this.ScoreBoardPanel.TabIndex = 0;
            // 
            // MapPanel
            // 
            this.MapPanel.AutoSize = true;
            this.MapPanel.Location = new System.Drawing.Point(215, 12);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(800, 557);
            this.MapPanel.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::group2Project.Properties.Resources.icons8_close_window_64;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Location = new System.Drawing.Point(1044, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 44);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1102, 581);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ScoreBoardPanel);
            this.Controls.Add(this.MapPanel);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ScoreBoardPanel;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button CloseButton;
    }
}