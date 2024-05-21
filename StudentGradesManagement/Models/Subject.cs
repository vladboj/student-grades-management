using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Models
{
    internal class Subject
    {
        private int id;
        private string name;
        private string teacher;
        private int credits;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Teacher { get { return teacher; } set { teacher = value; } }
        public int Credits { get { return credits; } set { credits = value; } }
    }
}
