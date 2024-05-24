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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentGradesManagement.Forms
{
    public partial class DashboardForm : Form
    {
        Dashboard Dashboard { get; set; }

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
                string[] row = new string[] { Dashboard.Students[i].Id.ToString(), Dashboard.Students[i].FirstName, Dashboard.Students[i].LastName, Dashboard.Students[i].DateOfBirth.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = Dashboard.Students[i];
                listViewStudents.Items.Add(item);
            }
            foreach (ColumnHeader column in listViewStudents.Columns)
            {
                column.Width = -2; // -2 resizes to fit the column header and the items
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            if(studentsForm.ShowDialog() == DialogResult.OK)
            {
                Dashboard.Students.Add(studentsForm.Student);
                displayStudents();
            }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {

        }
    }
}
