namespace group2Project.Views
{
    partial class ScoreBoard
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
            this.ScoreBoardList = new System.Windows.Forms.ListView();
            this.Players = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreBoardList
            // 
            this.ScoreBoardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ScoreBoardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Players,
            this.Data});
            this.ScoreBoardList.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userBindingSource, "userName", true));
            this.ScoreBoardList.HideSelection = false;
            this.ScoreBoardList.Location = new System.Drawing.Point(14, 14);
            this.ScoreBoardList.Name = "ScoreBoardList";
            this.ScoreBoardList.Size = new System.Drawing.Size(184, 494);
            this.ScoreBoardList.TabIndex = 3;
            this.ScoreBoardList.UseCompatibleStateImageBehavior = false;
            this.ScoreBoardList.View = System.Windows.Forms.View.Details;
            this.ScoreBoardList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Players
            // 
            this.Players.Text = "Scoreboard";
            this.Players.Width = 90;
            // 
            // Data
            // 
            this.Data.Text = "";
            this.Data.Width = 90;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(group2Project.Models.Student);
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(707, 518);
            this.Controls.Add(this.ScoreBoardList);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userBindingSource, "userName", true));
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ColumnHeader Players;
        private System.Windows.Forms.BindingSource userBindingSource;
        public System.Windows.Forms.ListView ScoreBoardList;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.Timer timer1;
    }
}