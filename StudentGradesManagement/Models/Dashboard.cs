using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Models
{
    internal class Dashboard
    {
        private List<Student> students;
        private List<Subject> subjects;

        public List<Student> Students { get { return students; } }
        public List<Subject> Subjects { get { return subjects; } }
    }
}
