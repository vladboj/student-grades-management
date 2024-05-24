using StudentGradesManagement.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Models
{
    public class Dashboard
    {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }

        public Dashboard() { 
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
    }
}
