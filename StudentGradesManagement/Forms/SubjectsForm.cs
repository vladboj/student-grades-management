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
    public partial class SubjectsForm : Form
    {
        public Subject Subject { get; set; }

        public SubjectsForm()
        {
            InitializeComponent();
            Subject = new Subject();
        }

        private void buttonSubmitSubject_Click(object sender, EventArgs e)
        {
            Subject.Id = (int)numericUpDownId.Value;
            Subject.Name = textBoxName.Text;
            Subject.Teacher = textBoxTeacher.Text;
            Subject.Credits = (int)numericUpDownCredits.Value;
        }
    }
}
