using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Unicom_TIC_Management_System.Repositories
{
    internal class DatabaseManager
    {
        public static void CreateTables()
        {
            using (var conn = DBConnection.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Sections (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Teachers (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Phone TEXT NOT NULL,
                        Address TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Students (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        SectionId INTEGER,
                        FOREIGN KEY (SectionId) REFERENCES Sections(Id)
                    );

                    CREATE TABLE IF NOT EXISTS StudentTeacher (
                        StudentId INTEGER,
                        TeacherId INTEGER,
                        PRIMARY KEY (StudentId, TeacherId),
                        FOREIGN KEY (StudentId) REFERENCES Students(Id),
                        FOREIGN KEY (TeacherId) REFERENCES Teachers(Id)
                    );

                    CREATE TABLE IF NOT EXISTS TeacherSection (
                        TeacherId INTEGER,
                        SectionId INTEGER,
                        PRIMARY KEY (TeacherId, SectionId),
                        FOREIGN KEY (TeacherId) REFERENCES Teachers(Id),
                        FOREIGN KEY (SectionId) REFERENCES Sections(Id)
                    );
                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
