namespace Lab4.View
{
    partial class TeachersForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.teachersListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateBirthdayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeTeachertButton = new System.Windows.Forms.Button();
            this.newTeacherButton = new System.Windows.Forms.Button();
            this.removeSubjectButton = new System.Windows.Forms.Button();
            this.newSubjectButton = new System.Windows.Forms.Button();
            this.subjectsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.Location = new System.Drawing.Point(642, 20);
            this.backButton.Margin = new System.Windows.Forms.Padding(1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 29);
            this.backButton.TabIndex = 25;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backlButton_Click);
            // 
            // teachersListView
            // 
            this.teachersListView.AutoArrange = false;
            this.teachersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teachersListView.CheckBoxes = true;
            this.teachersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.idColumn,
            this.nameColumn,
            this.dateBirthdayColumn,
            this.titleColumn});
            this.teachersListView.GridLines = true;
            this.teachersListView.Location = new System.Drawing.Point(318, 66);
            this.teachersListView.Margin = new System.Windows.Forms.Padding(1);
            this.teachersListView.MultiSelect = false;
            this.teachersListView.Name = "teachersListView";
            this.teachersListView.Scrollable = false;
            this.teachersListView.Size = new System.Drawing.Size(455, 314);
            this.teachersListView.TabIndex = 24;
            this.teachersListView.UseCompatibleStateImageBehavior = false;
            this.teachersListView.View = System.Windows.Forms.View.Details;
            this.teachersListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.teachersListView_ColumnWidthChanging);
            this.teachersListView.SelectedIndexChanged += new System.EventHandler(this.teachersListView_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 36;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.Width = 70;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Фио";
            this.nameColumn.Width = 160;
            // 
            // dateBirthdayColumn
            // 
            this.dateBirthdayColumn.Text = "Дата рождения";
            this.dateBirthdayColumn.Width = 100;
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Должность";
            this.titleColumn.Width = 71;
            // 
            // removeTeachertButton
            // 
            this.removeTeachertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeTeachertButton.Location = new System.Drawing.Point(691, 398);
            this.removeTeachertButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeTeachertButton.Name = "removeTeachertButton";
            this.removeTeachertButton.Size = new System.Drawing.Size(82, 29);
            this.removeTeachertButton.TabIndex = 23;
            this.removeTeachertButton.Text = "Удалить";
            this.removeTeachertButton.UseVisualStyleBackColor = true;
            this.removeTeachertButton.Click += new System.EventHandler(this.removeTeachertButton_Click);
            // 
            // newTeacherButton
            // 
            this.newTeacherButton.Enabled = false;
            this.newTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newTeacherButton.Location = new System.Drawing.Point(577, 398);
            this.newTeacherButton.Margin = new System.Windows.Forms.Padding(1);
            this.newTeacherButton.Name = "newTeacherButton";
            this.newTeacherButton.Size = new System.Drawing.Size(89, 29);
            this.newTeacherButton.TabIndex = 22;
            this.newTeacherButton.Text = "Добавить";
            this.newTeacherButton.UseVisualStyleBackColor = true;
            // 
            // removeSubjectButton
            // 
            this.removeSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSubjectButton.Location = new System.Drawing.Point(142, 398);
            this.removeSubjectButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeSubjectButton.Name = "removeSubjectButton";
            this.removeSubjectButton.Size = new System.Drawing.Size(72, 29);
            this.removeSubjectButton.TabIndex = 28;
            this.removeSubjectButton.Text = "Удалить";
            this.removeSubjectButton.UseVisualStyleBackColor = true;
            // 
            // newSubjectButton
            // 
            this.newSubjectButton.Enabled = false;
            this.newSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSubjectButton.Location = new System.Drawing.Point(54, 399);
            this.newSubjectButton.Margin = new System.Windows.Forms.Padding(1);
            this.newSubjectButton.Name = "newSubjectButton";
            this.newSubjectButton.Size = new System.Drawing.Size(86, 29);
            this.newSubjectButton.TabIndex = 27;
            this.newSubjectButton.Text = "Добавить";
            this.newSubjectButton.UseVisualStyleBackColor = true;
            this.newSubjectButton.Click += new System.EventHandler(this.newSubjectButton_Click);
            // 
            // subjectsListView
            // 
            this.subjectsListView.BackColor = System.Drawing.SystemColors.Window;
            this.subjectsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectsListView.CheckBoxes = true;
            this.subjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Subject,
            this.teacherColumn});
            this.subjectsListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.subjectsListView.FullRowSelect = true;
            this.subjectsListView.GridLines = true;
            this.subjectsListView.HideSelection = false;
            this.subjectsListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.subjectsListView.Location = new System.Drawing.Point(26, 66);
            this.subjectsListView.Margin = new System.Windows.Forms.Padding(1);
            this.subjectsListView.MultiSelect = false;
            this.subjectsListView.Name = "subjectsListView";
            this.subjectsListView.Scrollable = false;
            this.subjectsListView.Size = new System.Drawing.Size(278, 314);
            this.subjectsListView.TabIndex = 26;
            this.subjectsListView.UseCompatibleStateImageBehavior = false;
            this.subjectsListView.View = System.Windows.Forms.View.Details;
            this.subjectsListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.subjectsListView_ColumnWidthChanging);
            this.subjectsListView.SelectedIndexChanged += new System.EventHandler(this.subjectsListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // Subject
            // 
            this.Subject.Text = "Предмет";
            this.Subject.Width = 96;
            // 
            // teacherColumn
            // 
            this.teacherColumn.Text = "Преподаватель";
            this.teacherColumn.Width = 200;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeSubjectButton);
            this.Controls.Add(this.newSubjectButton);
            this.Controls.Add(this.subjectsListView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.teachersListView);
            this.Controls.Add(this.removeTeachertButton);
            this.Controls.Add(this.newTeacherButton);
            this.Name = "TeachersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView teachersListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateBirthdayColumn;
        private System.Windows.Forms.Button removeTeachertButton;
        private System.Windows.Forms.Button newTeacherButton;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.Button removeSubjectButton;
        private System.Windows.Forms.Button newSubjectButton;
        private System.Windows.Forms.ListView subjectsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader teacherColumn;
    }
}