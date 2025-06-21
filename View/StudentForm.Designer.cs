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
            this.Student_Namelb = new System.Windows.Forms.Label();
            this.student_menu_pn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Student_Phone_No_lb = new System.Windows.Forms.Label();
            this.Student_name_textBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Phone_NotextBox = new System.Windows.Forms.TextBox();
            this.Course_name_lb = new System.Windows.Forms.Label();
            this.Course_NamecomboBox = new System.Windows.Forms.ComboBox();
            this.Search_lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.student_header_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // student_header_pn
            // 
            this.student_header_pn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_header_pn.Controls.Add(this.label1);
            this.student_header_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_header_pn.Location = new System.Drawing.Point(0, 0);
            this.student_header_pn.Name = "student_header_pn";
            this.student_header_pn.Size = new System.Drawing.Size(730, 43);
            this.student_header_pn.TabIndex = 1;
            // 
            // Student_Namelb
            // 
            this.Student_Namelb.AutoSize = true;
            this.Student_Namelb.Location = new System.Drawing.Point(116, 111);
            this.Student_Namelb.Name = "Student_Namelb";
            this.Student_Namelb.Size = new System.Drawing.Size(94, 13);
            this.Student_Namelb.TabIndex = 2;
            this.Student_Namelb.Text = "Student FullName ";
            // 
            // student_menu_pn
            // 
            this.student_menu_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.student_menu_pn.Location = new System.Drawing.Point(0, 43);
            this.student_menu_pn.Name = "student_menu_pn";
            this.student_menu_pn.Size = new System.Drawing.Size(730, 45);
            this.student_menu_pn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email Address";
            // 
            // Student_Phone_No_lb
            // 
            this.Student_Phone_No_lb.AutoSize = true;
            this.Student_Phone_No_lb.Location = new System.Drawing.Point(116, 151);
            this.Student_Phone_No_lb.Name = "Student_Phone_No_lb";
            this.Student_Phone_No_lb.Size = new System.Drawing.Size(78, 13);
            this.Student_Phone_No_lb.TabIndex = 5;
            this.Student_Phone_No_lb.Text = "Phone Number";
            // 
            // Student_name_textBox
            // 
            this.Student_name_textBox.Location = new System.Drawing.Point(236, 108);
            this.Student_name_textBox.Name = "Student_name_textBox";
            this.Student_name_textBox.Size = new System.Drawing.Size(325, 20);
            this.Student_name_textBox.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Phone_NotextBox
            // 
            this.Phone_NotextBox.Location = new System.Drawing.Point(236, 148);
            this.Phone_NotextBox.Name = "Phone_NotextBox";
            this.Phone_NotextBox.Size = new System.Drawing.Size(325, 20);
            this.Phone_NotextBox.TabIndex = 8;
            // 
            // Course_name_lb
            // 
            this.Course_name_lb.AutoSize = true;
            this.Course_name_lb.Location = new System.Drawing.Point(116, 231);
            this.Course_name_lb.Name = "Course_name_lb";
            this.Course_name_lb.Size = new System.Drawing.Size(71, 13);
            this.Course_name_lb.TabIndex = 9;
            this.Course_name_lb.Text = "Course Name";
            // 
            // Course_NamecomboBox
            // 
            this.Course_NamecomboBox.FormattingEnabled = true;
            this.Course_NamecomboBox.Location = new System.Drawing.Point(236, 228);
            this.Course_NamecomboBox.Name = "Course_NamecomboBox";
            this.Course_NamecomboBox.Size = new System.Drawing.Size(325, 21);
            this.Course_NamecomboBox.TabIndex = 10;
            // 
            // Search_lb
            // 
            this.Search_lb.AutoSize = true;
            this.Search_lb.Location = new System.Drawing.Point(116, 271);
            this.Search_lb.Name = "Search_lb";
            this.Search_lb.Size = new System.Drawing.Size(41, 13);
            this.Search_lb.TabIndex = 11;
            this.Search_lb.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 195);
            this.dataGridView1.TabIndex = 13;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_lb);
            this.Controls.Add(this.Course_NamecomboBox);
            this.Controls.Add(this.Course_name_lb);
            this.Controls.Add(this.Phone_NotextBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Student_name_textBox);
            this.Controls.Add(this.Student_Phone_No_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student_menu_pn);
            this.Controls.Add(this.Student_Namelb);
            this.Controls.Add(this.student_header_pn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.student_header_pn.ResumeLayout(false);
            this.student_header_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel student_header_pn;
        private System.Windows.Forms.Label Student_Namelb;
        private System.Windows.Forms.Panel student_menu_pn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Student_Phone_No_lb;
        private System.Windows.Forms.TextBox Student_name_textBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Phone_NotextBox;
        private System.Windows.Forms.Label Course_name_lb;
        private System.Windows.Forms.ComboBox Course_NamecomboBox;
        private System.Windows.Forms.Label Search_lb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}