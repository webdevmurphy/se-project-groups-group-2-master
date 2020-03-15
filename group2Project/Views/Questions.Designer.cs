namespace group2Project.Views
{
    partial class Questions
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
            this.ViewButton = new System.Windows.Forms.Button();
            this.Answerlbl = new System.Windows.Forms.Label();
            this.AnserTxtBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.QuestionTxtBox = new System.Windows.Forms.TextBox();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.AutoSize = true;
            this.formPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formPanel.Controls.Add(this.ViewButton);
            this.formPanel.Controls.Add(this.Answerlbl);
            this.formPanel.Controls.Add(this.AnserTxtBox);
            this.formPanel.Controls.Add(this.CancelBtn);
            this.formPanel.Controls.Add(this.SubmitBtn);
            this.formPanel.Controls.Add(this.QuestionTxtBox);
            this.formPanel.Controls.Add(this.QuestionLbl);
            this.formPanel.Location = new System.Drawing.Point(3, 3);
            this.formPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1025, 436);
            this.formPanel.TabIndex = 0;
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(792, 346);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(214, 61);
            this.ViewButton.TabIndex = 5;
            this.ViewButton.Text = "View Questions";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // Answerlbl
            // 
            this.Answerlbl.AutoSize = true;
            this.Answerlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answerlbl.Location = new System.Drawing.Point(94, 226);
            this.Answerlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answerlbl.Name = "Answerlbl";
            this.Answerlbl.Size = new System.Drawing.Size(102, 21);
            this.Answerlbl.TabIndex = 4;
            this.Answerlbl.Text = "Enter Answer";
            // 
            // AnserTxtBox
            // 
            this.AnserTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnserTxtBox.Location = new System.Drawing.Point(268, 221);
            this.AnserTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnserTxtBox.Name = "AnserTxtBox";
            this.AnserTxtBox.Size = new System.Drawing.Size(186, 29);
            this.AnserTxtBox.TabIndex = 3;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(542, 346);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 61);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(672, 346);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(112, 61);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // QuestionTxtBox
            // 
            this.QuestionTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTxtBox.Location = new System.Drawing.Point(268, 132);
            this.QuestionTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuestionTxtBox.Name = "QuestionTxtBox";
            this.QuestionTxtBox.Size = new System.Drawing.Size(386, 29);
            this.QuestionTxtBox.TabIndex = 1;
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLbl.Location = new System.Drawing.Point(94, 137);
            this.QuestionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(113, 21);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = "Enter Question";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 441);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Questions";
            this.Text = "Questions";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label Answerlbl;
        private System.Windows.Forms.TextBox AnserTxtBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox QuestionTxtBox;
        private System.Windows.Forms.Label QuestionLbl;
    }
}

