using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Lecturer
    {
        public int Lecturer_ID {  get; set; }
        public int Lecturer_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Subject_ID {  get; set; }
        public string Subject_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Course_ID {  get; set; }
        public string Course_Name { get;set; }
    }
}
