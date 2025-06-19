namespace Unicom_TIC_Management_System
{
    partial class MainForm
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
            this.Centerpanel = new System.Windows.Forms.Panel();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.lbmark = new System.Windows.Forms.Label();
            this.lbexam = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbtimetable = new System.Windows.Forms.Label();
            this.lbstaff = new System.Windows.Forms.Label();
            this.lblecturer = new System.Windows.Forms.Label();
            this.lbstudent = new System.Windows.Forms.Label();
            this.Leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Centerpanel
            // 
            this.Centerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Centerpanel.Location = new System.Drawing.Point(171, 0);
            this.Centerpanel.Name = "Centerpanel";
            this.Centerpanel.Size = new System.Drawing.Size(729, 550);
            this.Centerpanel.TabIndex = 3;
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Leftpanel.Controls.Add(this.lbmark);
            this.Leftpanel.Controls.Add(this.lbexam);
            this.Leftpanel.Controls.Add(this.lbCourse);
            this.Leftpanel.Controls.Add(this.lbtimetable);
            this.Leftpanel.Controls.Add(this.lbstaff);
            this.Leftpanel.Controls.Add(this.lblecturer);
            this.Leftpanel.Controls.Add(this.lbstudent);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(171, 550);
            this.Leftpanel.TabIndex = 2;
            // 
            // lbmark
            // 
            this.lbmark.AutoSize = true;
            this.lbmark.Location = new System.Drawing.Point(46, 153);
            this.lbmark.Name = "lbmark";
            this.lbmark.Size = new System.Drawing.Size(36, 13);
            this.lbmark.TabIndex = 6;
            this.lbmark.Text = "Marks";
            this.lbmark.Click += new System.EventHandler(this.lbmark_Click);
            // 
            // lbexam
            // 
            this.lbexam.AutoSize = true;
            this.lbexam.Location = new System.Drawing.Point(46, 107);
            this.lbexam.Name = "lbexam";
            this.lbexam.Size = new System.Drawing.Size(38, 13);
            this.lbexam.TabIndex = 5;
            this.lbexam.Text = "Exams";
            this.lbexam.Click += new System.EventHandler(this.lbexam_Click);
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(46, 199);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(40, 13);
            this.lbCourse.TabIndex = 4;
            this.lbCourse.Text = "Course";
            this.lbCourse.Click += new System.EventHandler(this.lbCourse_Click);
            // 
            // lbtimetable
            // 
            this.lbtimetable.AutoSize = true;
            this.lbtimetable.Location = new System.Drawing.Point(46, 61);
            this.lbtimetable.Name = "lbtimetable";
            this.lbtimetable.Size = new System.Drawing.Size(60, 13);
            this.lbtimetable.TabIndex = 3;
            this.lbtimetable.Text = "Time Table";
            this.lbtimetable.Click += new System.EventHandler(this.lbtimetable_Click);
            // 
            // lbstaff
            // 
            this.lbstaff.AutoSize = true;
            this.lbstaff.Location = new System.Drawing.Point(46, 337);
            this.lbstaff.Name = "lbstaff";
            this.lbstaff.Size = new System.Drawing.Size(34, 13);
            this.lbstaff.TabIndex = 2;
            this.lbstaff.Text = "Staffs";
            this.lbstaff.Click += new System.EventHandler(this.lbstaff_Click);
            // 
            // lblecturer
            // 
            this.lblecturer.AutoSize = true;
            this.lblecturer.Location = new System.Drawing.Point(46, 291);
            this.lblecturer.Name = "lblecturer";
            this.lblecturer.Size = new System.Drawing.Size(51, 13);
            this.lblecturer.TabIndex = 1;
            this.lblecturer.Text = "Lecturers";
            this.lblecturer.Click += new System.EventHandler(this.lblecturer_Click);
            // 
            // lbstudent
            // 
            this.lbstudent.AutoSize = true;
            this.lbstudent.Location = new System.Drawing.Point(46, 245);
            this.lbstudent.Name = "lbstudent";
            this.lbstudent.Size = new System.Drawing.Size(49, 13);
            this.lbstudent.TabIndex = 0;
            this.lbstudent.Text = "Students";
            this.lbstudent.Click += new System.EventHandler(this.lbstudent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.Centerpanel);
            this.Controls.Add(this.Leftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Centerpanel;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Label lbmark;
        private System.Windows.Forms.Label lbexam;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbtimetable;
        private System.Windows.Forms.Label lbstaff;
        private System.Windows.Forms.Label lblecturer;
        private System.Windows.Forms.Label lbstudent;
    }
}