using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Controller
{
    internal class StudentController
    {
        public void InsertStudent(string name, string address,string email)
        {
            string insertQuery = "INSERT INTO Student (Student_Name, Student_Phone_No, Student_Email) VALUES (@Name, @Phone_no,@Email)";

            using (var conn = DBConnection.GetConnection())
            {

                using (var cmd = new SQLiteCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Phone_no", address);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
