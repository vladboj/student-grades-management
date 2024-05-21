using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesManagement.Models
{
    internal class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private List<Subject> subjects;

        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public List<Subject> Subjects { get { return subjects; } }
    }
}
