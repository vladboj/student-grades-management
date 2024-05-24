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
        private List<Subject> allSubjects;

        public StudentsForm(Dashboard dashboard)
        {
            InitializeComponent();
            Student = new Student();
            allSubjects = dashboard.Subjects;
            InitializeCheckedListBox();
        }

        private void buttonSubmitStudent_Click(object sender, EventArgs e)
        {
            Student.Id = (int)numericUpDownId.Value;
            Student.FirstName = textBoxFirstName.Text;
            Student.LastName = textBoxLastName.Text;
            Student.DateOfBirth = dateTimePickerDateOfBirth.Value;
            foreach (Subject subject in checkedListBoxSubjects.CheckedItems)
            {
                Student.Subjects.Add(subject);
            }
        }

        private void InitializeCheckedListBox()
        {
            // Load subjects from the listViewSubjects
            for (int i = 0; i < allSubjects.Count; i++)
            {
                checkedListBoxSubjects.Items.Add(allSubjects[i]);
            }
            checkedListBoxSubjects.DisplayMember = "Name";
        }
    }
}
