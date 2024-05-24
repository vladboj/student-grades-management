using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Models
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {
            Subjects = new List<Subject>();
        }

        public float getAge()
        {
            TimeSpan difference = System.DateTime.Now - DateOfBirth;
            return difference.Days / 365;
        }
    }
}
