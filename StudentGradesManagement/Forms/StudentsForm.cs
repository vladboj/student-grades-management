using StudentGradesManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradesManagement.Forms
{
    public partial class StudentsForm : Form
    {
        public Student Student { get; set; }

        public StudentsForm()
        {
            InitializeComponent();
            Student = new Student();
        }

        private void buttonSubmitStudent_Click(object sender, EventArgs e)
        {
            Student.Id = (int)numericUpDownId.Value;
            Student.FirstName = textBoxFirstName.Text;
            Student.LastName = textBoxLastName.Text;
            Student.DateOfBirth = dateTimePickerDateOfBirth.Value;
        }
    }
}
