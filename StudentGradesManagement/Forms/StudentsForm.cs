using StudentGradesManagement.Models;
using System.IO;
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
            Student.DateOfBirth = DateTime.Now;
            allSubjects = dashboard.Subjects;
            InitializeCheckedListBox();
        }

        private void InitializeCheckedListBox()
        {
            try
            {
                if(allSubjects == null)
                {
                    throw new NullReferenceException("allSubjects list is null.");
                }
                // Load subjects from the listViewSubjects
                for (int i = 0; i < allSubjects.Count; i++)
                {
                    checkedListBoxSubjects.Items.Add(allSubjects[i]);
                }
                checkedListBoxSubjects.DisplayMember = "Name";
            }
            catch (NullReferenceException nre)
            {
                string logFilePath = "C:\\Users\\vladb\\mine\\Repositories\\StudentGradesManagement\\StudentGradesManagement\\logs.txt";
                using (StreamWriter writer = new StreamWriter(logFilePath))
                {
                    Console.SetOut(writer);
                    Console.WriteLine($"Error: {nre.Message}");
                }
            }
        }

        public class CustomException : Exception
        {
            public CustomException(string message) : base(message)
            {
            }
        }

        private void buttonSubmitStudent_Click(object sender, EventArgs e)
        {
            Student.Id = (int)numericUpDownId.Value;
            try
            {
                if(string.IsNullOrEmpty(textBoxFirstName.Text))
                {
                    throw new CustomException("First name cannot be empty.");
                }
                Student.FirstName = textBoxFirstName.Text;
            }
            catch(CustomException ce)
            {
                string logFilePath = "C:\\Users\\vladb\\mine\\Repositories\\StudentGradesManagement\\StudentGradesManagement\\logs.txt";
                using (StreamWriter writer = new StreamWriter(logFilePath))
                {
                    Console.SetOut(writer);
                    Console.WriteLine($"Error: {ce.Message}");
                }
            }

            Student.LastName = textBoxLastName.Text;
            Student.DateOfBirth = dateTimePickerDateOfBirth.Value;
            Student.Subjects.Clear();
            foreach (Subject subject in checkedListBoxSubjects.CheckedItems)
            {
                Student.Subjects.Add(subject);
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            numericUpDownId.Value = Student.Id;
            textBoxFirstName.Text = Student.FirstName;
            textBoxLastName.Text = Student.LastName;
            dateTimePickerDateOfBirth.Value = Student.DateOfBirth;
            for (int i = 0; i < allSubjects.Count; i++)
            {
                if (Student.Subjects.Any() && Student.Subjects.Contains(allSubjects[i]))
                {
                    checkedListBoxSubjects.SetItemChecked(i, true);
                }
            }
        }

        private void numericUpDownId_Validating(object sender, CancelEventArgs e)
        {
            if(numericUpDownId.Value < 1 || numericUpDownId.Value > 100)
            {
                e.Cancel = true;
                errorProvider.SetError(numericUpDownId, "ID must be between 1 and 100!");
                numericUpDownId.BackColor = Color.Red;
            }
            else
            {
                errorProvider.SetError(numericUpDownId, "");
            }
        }

        private void numericUpDownId_Validated(object sender, EventArgs e)
        {
            numericUpDownId.BackColor = SystemColors.Window;
        }
    }
}
