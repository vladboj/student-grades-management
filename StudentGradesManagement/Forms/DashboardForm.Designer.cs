namespace StudentGradesManagement.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.columnStudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSubjects = new System.Windows.Forms.ListView();
            this.columnSubjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.Location = new System.Drawing.Point(413, 717);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(281, 114);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSubject.Location = new System.Drawing.Point(1187, 717);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(270, 114);
            this.buttonAddSubject.TabIndex = 1;
            this.buttonAddSubject.Text = "Add Subject";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // listViewStudents
            // 
            this.listViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStudentId,
            this.columnFirstName,
            this.columnLastName,
            this.columnDateOfBirth,
            this.columnSubjects});
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(68, 47);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(958, 562);
            this.listViewStudents.TabIndex = 2;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnStudentId
            // 
            this.columnStudentId.Text = "ID";
            this.columnStudentId.Width = -2;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFirstName.Width = -2;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLastName.Width = -2;
            // 
            // columnDateOfBirth
            // 
            this.columnDateOfBirth.Text = "Date of Birth";
            this.columnDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDateOfBirth.Width = -2;
            // 
            // columnSubjects
            // 
            this.columnSubjects.Text = "Subjects";
            this.columnSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSubjects.Width = -2;
            // 
            // listViewSubjects
            // 
            this.listViewSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listViewSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubjectId,
            this.columnSubjectName,
            this.columnTeacherName,
            this.columnCredits});
            this.listViewSubjects.GridLines = true;
            this.listViewSubjects.HideSelection = false;
            this.listViewSubjects.Location = new System.Drawing.Point(1083, 47);
            this.listViewSubjects.Name = "listViewSubjects";
            this.listViewSubjects.Size = new System.Drawing.Size(527, 562);
            this.listViewSubjects.TabIndex = 3;
            this.listViewSubjects.UseCompatibleStateImageBehavior = false;
            this.listViewSubjects.View = System.Windows.Forms.View.Details;
            // 
            // columnSubjectId
            // 
            this.columnSubjectId.Text = "ID";
            // 
            // columnSubjectName
            // 
            this.columnSubjectName.Text = "Name";
            this.columnSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnTeacherName
            // 
            this.columnTeacherName.Text = "Teacher Name";
            this.columnTeacherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnCredits
            // 
            this.columnCredits.Text = "Credits";
            this.columnCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1674, 929);
            this.Controls.Add(this.listViewSubjects);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.buttonAddStudent);
            this.MinimumSize = new System.Drawing.Size(1700, 1000);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ListView listViewSubjects;
        private System.Windows.Forms.ColumnHeader columnStudentId;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnDateOfBirth;
        private System.Windows.Forms.ColumnHeader columnSubjects;
        private System.Windows.Forms.ColumnHeader columnSubjectId;
        private System.Windows.Forms.ColumnHeader columnSubjectName;
        private System.Windows.Forms.ColumnHeader columnTeacherName;
        private System.Windows.Forms.ColumnHeader columnCredits;
    }
}