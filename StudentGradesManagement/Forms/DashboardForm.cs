using StudentGradesManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentGradesManagement.Forms
{
    public partial class DashboardForm : Form
    {
        public Dashboard Dashboard { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
            Dashboard = new Dashboard();
        }

        private void displayStudents()
        {
            listViewStudents.Items.Clear();
            for(int i = 0; i < Dashboard.Students.Count; i++)
            {
                string subjectsNames = "";
                foreach (Subject subject in Dashboard.Students[i].Subjects)
                {
                    subjectsNames += subject.Name + ", ";
                }
                if(subjectsNames.Length > 0)
                {
                    subjectsNames = subjectsNames.Substring(0, subjectsNames.Length - 2);
                }
                string[] row = new string[] { 
                    Dashboard.Students[i].Id.ToString(), 
                    Dashboard.Students[i].FirstName, 
                    Dashboard.Students[i].LastName, 
                    Dashboard.Students[i].DateOfBirth.Date.ToShortDateString(),
                    subjectsNames
                };
                ListViewItem item = new ListViewItem(row);
                item.Tag = Dashboard.Students[i];
                listViewStudents.Items.Add(item);
            }
            foreach (ColumnHeader column in listViewStudents.Columns)
            {
                column.Width = -2; // -2 resizes to fit the column header and the items
            }
        }

        private void displaySubjects()
        {
            listViewSubjects.Items.Clear();
            for (int i = 0; i < Dashboard.Subjects.Count; i++)
            {
                string[] row = new string[] { 
                    Dashboard.Subjects[i].Id.ToString(), 
                    Dashboard.Subjects[i].Name, 
                    Dashboard.Subjects[i].Teacher, 
                    Dashboard.Subjects[i].Credits.ToString() 
                };
                ListViewItem item = new ListViewItem(row);
                item.Tag = Dashboard.Subjects[i];
                listViewSubjects.Items.Add(item);
            }
            foreach (ColumnHeader column in listViewSubjects.Columns)
            {
                column.Width = -2; // -2 resizes to fit the column header and the items
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm(Dashboard);
            if(studentsForm.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Students.Add(studentsForm.Student);
                displayStudents();
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            if(subjectsForm.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Subjects.Add(subjectsForm.Subject);
                displaySubjects();
            }
        }

        private void editToolStripMenuStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                StudentsForm studentsForm = new StudentsForm(Dashboard);
                studentsForm.Student = listViewStudents.SelectedItems[0].Tag as Student;
                if (studentsForm.ShowDialog() == DialogResult.OK)
                {
                    displayStudents();
                }
            }
        }

        private void editToolStripMenuSubject_Click(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                SubjectsForm subjectsForm = new SubjectsForm();
                subjectsForm.Subject = listViewSubjects.SelectedItems[0].Tag as Subject;
                if (subjectsForm.ShowDialog() == DialogResult.OK)
                {
                    displaySubjects();
                }
            }
        }

        private void deleteToolStripMenuStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                Student toBeDeleted = listViewStudents.SelectedItems[0].Tag as Student;
                for (int i = 0; i < Dashboard.Students.Count; i++)
                {
                    if (Dashboard.Students[i] == toBeDeleted)
                    {
                        Dashboard.Students.RemoveAt(i);
                        break;
                    }
                }
                displayStudents();
            }
        }

        private void deleteToolStripMenuSubject_Click(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                Subject toBeDeleted = listViewSubjects.SelectedItems[0].Tag as Subject;
                for (int i = 0; i < Dashboard.Subjects.Count; i++)
                {
                    if (Dashboard.Subjects[i] == toBeDeleted)
                    {
                        Dashboard.Subjects.RemoveAt(i);
                        break;
                    }
                }
                displaySubjects();
            }
        }

        private void saveToFileToolStripMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, Dashboard.Students);
                }
            }
        }

        private void loadFromFileToolStripMenuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    Dashboard.Students = (List<Student>)binaryFormatter.Deserialize(fileStream);
                    displayStudents();
                }
            }
        }
    }
}
