namespace Unicom_TIC_Management_System.View
{
    partial class StudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_header_pn = new System.Windows.Forms.Panel();
            this.Student_Namelabel = new System.Windows.Forms.Label();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.Email_label = new System.Windows.Forms.Label();
            this.Student_Phone_No_lbeal = new System.Windows.Forms.Label();
            this.Student_name_textBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.Phone_NotextBox = new System.Windows.Forms.TextBox();
            this.Course_name_lbeal = new System.Windows.Forms.Label();
            this.Course_NamecomboBox = new System.Windows.Forms.ComboBox();
            this.Search_lbeal = new System.Windows.Forms.Label();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.student_header_pn.SuspendLayout();
            this.student_menu_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Details";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.label1);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 37);
            this.student_header_pn.TabIndex = 1;
            // 
            // Student_Namelabel
            // 
            this.Student_Namelabel.AutoSize = true;
            this.Student_Namelabel.Location = new System.Drawing.Point(141, 111);
            this.Student_Namelabel.Name = "Student_Namelabel";
            this.Student_Namelabel.Size = new System.Drawing.Size(94, 13);
            this.Student_Namelabel.TabIndex = 2;
            this.Student_Namelabel.Text = "Student FullName ";
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Controls.Add(this.Search_button);
            this.student_menu_pn.Controls.Add(this.button2);
            this.student_menu_pn.Controls.Add(this.Update_button);
            this.student_menu_pn.Controls.Add(this.Insert_button);
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 37);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 3;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(141, 191);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(73, 13);
            this.Email_label.TabIndex = 4;
            this.Email_label.Text = "Email Address";
            // 
            // Student_Phone_No_lbeal
            // 
            this.Student_Phone_No_lbeal.AutoSize = true;
            this.Student_Phone_No_lbeal.Location = new System.Drawing.Point(141, 151);
            this.Student_Phone_No_lbeal.Name = "Student_Phone_No_lbeal";
            this.Student_Phone_No_lbeal.Size = new System.Drawing.Size(78, 13);
            this.Student_Phone_No_lbeal.TabIndex = 5;
            this.Student_Phone_No_lbeal.Text = "Phone Number";
            // 
            // Student_name_textBox
            // 
            this.Student_name_textBox.Location = new System.Drawing.Point(261, 108);
            this.Student_name_textBox.Name = "Student_name_textBox";
            this.Student_name_textBox.Size = new System.Drawing.Size(325, 20);
            this.Student_name_textBox.TabIndex = 6;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(261, 188);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(325, 20);
            this.emailtextBox.TabIndex = 7;
            // 
            // Phone_NotextBox
            // 
            this.Phone_NotextBox.Location = new System.Drawing.Point(261, 148);
            this.Phone_NotextBox.Name = "Phone_NotextBox";
            this.Phone_NotextBox.Size = new System.Drawing.Size(325, 20);
            this.Phone_NotextBox.TabIndex = 8;
            // 
            // Course_name_lbeal
            // 
            this.Course_name_lbeal.AutoSize = true;
            this.Course_name_lbeal.Location = new System.Drawing.Point(141, 231);
            this.Course_name_lbeal.Name = "Course_name_lbeal";
            this.Course_name_lbeal.Size = new System.Drawing.Size(71, 13);
            this.Course_name_lbeal.TabIndex = 9;
            this.Course_name_lbeal.Text = "Course Name";
            // 
            // Course_NamecomboBox
            // 
            this.Course_NamecomboBox.FormattingEnabled = true;
            this.Course_NamecomboBox.Location = new System.Drawing.Point(261, 228);
            this.Course_NamecomboBox.Name = "Course_NamecomboBox";
            this.Course_NamecomboBox.Size = new System.Drawing.Size(325, 21);
            this.Course_NamecomboBox.TabIndex = 10;
            // 
            // Search_lbeal
            // 
            this.Search_lbeal.AutoSize = true;
            this.Search_lbeal.Location = new System.Drawing.Point(141, 271);
            this.Search_lbeal.Name = "Search_lbeal";
            this.Search_lbeal.Size = new System.Drawing.Size(41, 13);
            this.Search_lbeal.TabIndex = 11;
            this.Search_lbeal.Text = "Search";
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(261, 269);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(325, 20);
            this.Search_textBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 195);
            this.dataGridView1.TabIndex = 13;
            // 
            // Insert_button
            // 
            this.Insert_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Insert_button.Location = new System.Drawing.Point(131, 13);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(75, 23);
            this.Insert_button.TabIndex = 14;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = false;
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Update_button.Location = new System.Drawing.Point(260, 13);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 15;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(389, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Search_button.Location = new System.Drawing.Point(518, 13);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 17;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.Search_lbeal);
            this.Controls.Add(this.Course_NamecomboBox);
            this.Controls.Add(this.Course_name_lbeal);
            this.Controls.Add(this.Phone_NotextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.Student_name_textBox);
            this.Controls.Add(this.Student_Phone_No_lbeal);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.Student_Namelabel);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            this.student_menu_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Student_Namelabel;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Student_Phone_No_lbeal;
        private System.Windows.Forms.TextBox Student_name_textBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox Phone_NotextBox;
        private System.Windows.Forms.Label Course_name_lbeal;
        private System.Windows.Forms.ComboBox Course_NamecomboBox;
        private System.Windows.Forms.Label Search_lbeal;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Update_button;
    }
}