namespace StudentGradesManagement.Forms
{
    partial class SubjectsForm
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
            this.buttonSubmitSubject = new System.Windows.Forms.Button();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCredits = new System.Windows.Forms.NumericUpDown();
            this.labelCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmitSubject
            // 
            this.buttonSubmitSubject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSubmitSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmitSubject.Location = new System.Drawing.Point(422, 661);
            this.buttonSubmitSubject.Name = "buttonSubmitSubject";
            this.buttonSubmitSubject.Size = new System.Drawing.Size(228, 97);
            this.buttonSubmitSubject.TabIndex = 19;
            this.buttonSubmitSubject.Text = "Submit";
            this.buttonSubmitSubject.UseVisualStyleBackColor = true;
            this.buttonSubmitSubject.Click += new System.EventHandler(this.buttonSubmitSubject_Click);
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacher.Location = new System.Drawing.Point(467, 398);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(403, 49);
            this.textBoxTeacher.TabIndex = 17;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(467, 272);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(403, 49);
            this.textBoxName.TabIndex = 16;
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownId.Location = new System.Drawing.Point(467, 138);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(202, 49);
            this.numericUpDownId.TabIndex = 15;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacher.Location = new System.Drawing.Point(237, 401);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(163, 42);
            this.labelTeacher.TabIndex = 12;
            this.labelTeacher.Text = "Teacher";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(279, 275);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 42);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // numericUpDownCredits
            // 
            this.numericUpDownCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCredits.Location = new System.Drawing.Point(467, 520);
            this.numericUpDownCredits.Name = "numericUpDownCredits";
            this.numericUpDownCredits.Size = new System.Drawing.Size(202, 49);
            this.numericUpDownCredits.TabIndex = 21;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(257, 522);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(143, 42);
            this.labelCredits.TabIndex = 20;
            this.labelCredits.Text = "Credits";
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 929);
            this.Controls.Add(this.numericUpDownCredits);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.buttonSubmitSubject);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmitSubject;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCredits;
        private System.Windows.Forms.Label labelCredits;
    }
}