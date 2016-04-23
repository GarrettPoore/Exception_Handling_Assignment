namespace Exception_Handling_Assignment
{
    partial class Main
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
            this.lstShow = new System.Windows.Forms.ListBox();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstShow
            // 
            this.lstShow.FormattingEnabled = true;
            this.lstShow.HorizontalScrollbar = true;
            this.lstShow.Location = new System.Drawing.Point(34, 23);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(695, 238);
            this.lstShow.TabIndex = 0;
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(267, 296);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(99, 23);
            this.btnAddNewStudent.TabIndex = 1;
            this.btnAddNewStudent.Text = "Add New Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Program";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.lstShow);
            this.Name = "Main";
            this.Text = "Week 3 - Exception Handling Assignment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.Button btnExit;
    }
}

