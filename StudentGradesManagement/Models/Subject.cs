using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Credits { get; set; }
    }
}
