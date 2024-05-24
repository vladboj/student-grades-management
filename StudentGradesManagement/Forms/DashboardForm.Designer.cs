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
            this.components = new System.ComponentModel.Container();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.columnStudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewSubjects = new System.Windows.Forms.ListView();
            this.columnSubjectId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCredits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSubjects = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitleStudents = new System.Windows.Forms.Label();
            this.labelTitleSubjects = new System.Windows.Forms.Label();
            this.saveToFileToolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripStudents.SuspendLayout();
            this.contextMenuStripSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.Location = new System.Drawing.Point(377, 734);
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
            this.buttonAddSubject.Location = new System.Drawing.Point(1151, 734);
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
            this.listViewStudents.ContextMenuStrip = this.contextMenuStripStudents;
            this.listViewStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewStudents.FullRowSelect = true;
            this.listViewStudents.GridLines = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(41, 110);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(958, 562);
            this.listViewStudents.TabIndex = 2;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnStudentId
            // 
            this.columnStudentId.Text = "ID";
            this.columnStudentId.Width = 50;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnFirstName.Width = 116;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnLastName.Width = 115;
            // 
            // columnDateOfBirth
            // 
            this.columnDateOfBirth.Text = "Date of Birth";
            this.columnDateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDateOfBirth.Width = 131;
            // 
            // columnSubjects
            // 
            this.columnSubjects.Text = "Subjects";
            this.columnSubjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSubjects.Width = 542;
            // 
            // contextMenuStripStudents
            // 
            this.contextMenuStripStudents.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuStudent,
            this.deleteToolStripMenuStudent,
            this.saveToFileToolStripMenuSave,
            this.loadFromFileToolStripMenuLoad,
            this.generateReportToolStripMenuReport});
            this.contextMenuStripStudents.Name = "contextMenuStripStudents";
            this.contextMenuStripStudents.Size = new System.Drawing.Size(301, 238);
            // 
            // editToolStripMenuStudent
            // 
            this.editToolStripMenuStudent.Name = "editToolStripMenuStudent";
            this.editToolStripMenuStudent.Size = new System.Drawing.Size(300, 38);
            this.editToolStripMenuStudent.Text = "Edit";
            this.editToolStripMenuStudent.Click += new System.EventHandler(this.editToolStripMenuStudent_Click);
            // 
            // deleteToolStripMenuStudent
            // 
            this.deleteToolStripMenuStudent.Name = "deleteToolStripMenuStudent";
            this.deleteToolStripMenuStudent.Size = new System.Drawing.Size(300, 38);
            this.deleteToolStripMenuStudent.Text = "Delete";
            this.deleteToolStripMenuStudent.Click += new System.EventHandler(this.deleteToolStripMenuStudent_Click);
            // 
            // listViewSubjects
            // 
            this.listViewSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listViewSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubjectId,
            this.columnSubjectName,
            this.columnTeacherName,
            this.columnCredits});
            this.listViewSubjects.ContextMenuStrip = this.contextMenuStripSubjects;
            this.listViewSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSubjects.FullRowSelect = true;
            this.listViewSubjects.GridLines = true;
            this.listViewSubjects.HideSelection = false;
            this.listViewSubjects.Location = new System.Drawing.Point(1048, 110);
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
            // contextMenuStripSubjects
            // 
            this.contextMenuStripSubjects.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripSubjects.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuSubject,
            this.deleteToolStripMenuSubject});
            this.contextMenuStripSubjects.Name = "contextMenuStripSubjects";
            this.contextMenuStripSubjects.Size = new System.Drawing.Size(159, 80);
            // 
            // editToolStripMenuSubject
            // 
            this.editToolStripMenuSubject.Name = "editToolStripMenuSubject";
            this.editToolStripMenuSubject.Size = new System.Drawing.Size(158, 38);
            this.editToolStripMenuSubject.Text = "Edit";
            this.editToolStripMenuSubject.Click += new System.EventHandler(this.editToolStripMenuSubject_Click);
            // 
            // deleteToolStripMenuSubject
            // 
            this.deleteToolStripMenuSubject.Name = "deleteToolStripMenuSubject";
            this.deleteToolStripMenuSubject.Size = new System.Drawing.Size(158, 38);
            this.deleteToolStripMenuSubject.Text = "Delete";
            this.deleteToolStripMenuSubject.Click += new System.EventHandler(this.deleteToolStripMenuSubject_Click);
            // 
            // labelTitleStudents
            // 
            this.labelTitleStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitleStudents.AutoSize = true;
            this.labelTitleStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleStudents.Location = new System.Drawing.Point(406, 37);
            this.labelTitleStudents.Name = "labelTitleStudents";
            this.labelTitleStudents.Size = new System.Drawing.Size(174, 42);
            this.labelTitleStudents.TabIndex = 4;
            this.labelTitleStudents.Text = "Students";
            // 
            // labelTitleSubjects
            // 
            this.labelTitleSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitleSubjects.AutoSize = true;
            this.labelTitleSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSubjects.Location = new System.Drawing.Point(1229, 37);
            this.labelTitleSubjects.Name = "labelTitleSubjects";
            this.labelTitleSubjects.Size = new System.Drawing.Size(170, 42);
            this.labelTitleSubjects.TabIndex = 5;
            this.labelTitleSubjects.Text = "Subjects";
            // 
            // saveToFileToolStripMenuSave
            // 
            this.saveToFileToolStripMenuSave.Name = "saveToFileToolStripMenuSave";
            this.saveToFileToolStripMenuSave.Size = new System.Drawing.Size(300, 38);
            this.saveToFileToolStripMenuSave.Text = "Save to file";
            this.saveToFileToolStripMenuSave.Click += new System.EventHandler(this.saveToFileToolStripMenuSave_Click);
            // 
            // loadFromFileToolStripMenuLoad
            // 
            this.loadFromFileToolStripMenuLoad.Name = "loadFromFileToolStripMenuLoad";
            this.loadFromFileToolStripMenuLoad.Size = new System.Drawing.Size(300, 38);
            this.loadFromFileToolStripMenuLoad.Text = "Load from file";
            this.loadFromFileToolStripMenuLoad.Click += new System.EventHandler(this.loadFromFileToolStripMenuLoad_Click);
            // 
            // generateReportToolStripMenuReport
            // 
            this.generateReportToolStripMenuReport.Name = "generateReportToolStripMenuReport";
            this.generateReportToolStripMenuReport.Size = new System.Drawing.Size(300, 38);
            this.generateReportToolStripMenuReport.Text = "Generate report";
            this.generateReportToolStripMenuReport.Click += new System.EventHandler(this.generateReportToolStripMenuReport_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1674, 929);
            this.Controls.Add(this.labelTitleSubjects);
            this.Controls.Add(this.labelTitleStudents);
            this.Controls.Add(this.listViewSubjects);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.buttonAddStudent);
            this.MinimumSize = new System.Drawing.Size(1700, 1000);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.contextMenuStripStudents.ResumeLayout(false);
            this.contextMenuStripSubjects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStudents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSubjects;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuStudent;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuStudent;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuSubject;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuSubject;
        private System.Windows.Forms.Label labelTitleStudents;
        private System.Windows.Forms.Label labelTitleSubjects;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuLoad;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuReport;
    }
}