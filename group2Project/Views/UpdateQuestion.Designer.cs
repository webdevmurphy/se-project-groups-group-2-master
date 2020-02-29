namespace group2Project.Views
{
    partial class UpdateQuestion
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Answerlbl = new System.Windows.Forms.Label();
            this.Questionlbl = new System.Windows.Forms.Label();
            this.Answertxt = new System.Windows.Forms.TextBox();
            this.Questiontxt = new System.Windows.Forms.TextBox();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formPanel.Controls.Add(this.CancelBtn);
            this.formPanel.Controls.Add(this.SubmitBtn);
            this.formPanel.Controls.Add(this.Answerlbl);
            this.formPanel.Controls.Add(this.Questionlbl);
            this.formPanel.Controls.Add(this.Answertxt);
            this.formPanel.Controls.Add(this.Questiontxt);
            this.formPanel.Location = new System.Drawing.Point(-3, 0);
            this.formPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1204, 375);
            this.formPanel.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(874, 305);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 50);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(1012, 305);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(112, 50);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // Answerlbl
            // 
            this.Answerlbl.AutoSize = true;
            this.Answerlbl.Location = new System.Drawing.Point(298, 160);
            this.Answerlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answerlbl.Name = "Answerlbl";
            this.Answerlbl.Size = new System.Drawing.Size(62, 21);
            this.Answerlbl.TabIndex = 3;
            this.Answerlbl.Text = "Answer";
            // 
            // Questionlbl
            // 
            this.Questionlbl.AutoSize = true;
            this.Questionlbl.Location = new System.Drawing.Point(298, 87);
            this.Questionlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Questionlbl.Name = "Questionlbl";
            this.Questionlbl.Size = new System.Drawing.Size(73, 21);
            this.Questionlbl.TabIndex = 2;
            this.Questionlbl.Text = "Question";
            // 
            // Answertxt
            // 
            this.Answertxt.Location = new System.Drawing.Point(444, 155);
            this.Answertxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Answertxt.Name = "Answertxt";
            this.Answertxt.Size = new System.Drawing.Size(366, 29);
            this.Answertxt.TabIndex = 1;
            // 
            // Questiontxt
            // 
            this.Questiontxt.Location = new System.Drawing.Point(444, 82);
            this.Questiontxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Questiontxt.Name = "Questiontxt";
            this.Questiontxt.Size = new System.Drawing.Size(366, 29);
            this.Questiontxt.TabIndex = 0;
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 375);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateQuestion";
            this.Text = "Update Question";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label Answerlbl;
        private System.Windows.Forms.Label Questionlbl;
        private System.Windows.Forms.TextBox Answertxt;
        private System.Windows.Forms.TextBox Questiontxt;
    }
}