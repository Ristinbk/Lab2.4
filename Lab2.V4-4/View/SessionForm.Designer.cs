namespace Lab4.View
{
    partial class SessionForm
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
            this.removeSubjecttButton = new System.Windows.Forms.Button();
            this.groupListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectsListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionsListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.assessmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newSessionButton = new System.Windows.Forms.Button();
            this.newSubjectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeSessionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeSubjecttButton
            // 
            this.removeSubjecttButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeSubjecttButton.Location = new System.Drawing.Point(407, 127);
            this.removeSubjecttButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeSubjecttButton.Name = "removeSubjecttButton";
            this.removeSubjecttButton.Size = new System.Drawing.Size(81, 29);
            this.removeSubjecttButton.TabIndex = 24;
            this.removeSubjecttButton.Text = "Удалить";
            this.removeSubjecttButton.UseVisualStyleBackColor = true;
            this.removeSubjecttButton.Click += new System.EventHandler(this.removeSubjecttButton_Click);
            // 
            // groupListView
            // 
            this.groupListView.BackColor = System.Drawing.SystemColors.Window;
            this.groupListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupListView.CheckBoxes = true;
            this.groupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Group});
            this.groupListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupListView.FullRowSelect = true;
            this.groupListView.GridLines = true;
            this.groupListView.HideSelection = false;
            this.groupListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.groupListView.Location = new System.Drawing.Point(48, 185);
            this.groupListView.Margin = new System.Windows.Forms.Padding(1);
            this.groupListView.MultiSelect = false;
            this.groupListView.Name = "groupListView";
            this.groupListView.Scrollable = false;
            this.groupListView.Size = new System.Drawing.Size(146, 246);
            this.groupListView.TabIndex = 28;
            this.groupListView.UseCompatibleStateImageBehavior = false;
            this.groupListView.View = System.Windows.Forms.View.Details;
            this.groupListView.SelectedIndexChanged += new System.EventHandler(this.groupListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 26;
            // 
            // Group
            // 
            this.Group.Text = "Группа";
            this.Group.Width = 130;
            // 
            // subjectsListView
            // 
            this.subjectsListView.BackColor = System.Drawing.SystemColors.Window;
            this.subjectsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectsListView.CheckBoxes = true;
            this.subjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.subjectsListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.subjectsListView.FullRowSelect = true;
            this.subjectsListView.GridLines = true;
            this.subjectsListView.HideSelection = false;
            this.subjectsListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.subjectsListView.Location = new System.Drawing.Point(311, 25);
            this.subjectsListView.Margin = new System.Windows.Forms.Padding(1);
            this.subjectsListView.MultiSelect = false;
            this.subjectsListView.Name = "subjectsListView";
            this.subjectsListView.Scrollable = false;
            this.subjectsListView.Size = new System.Drawing.Size(94, 131);
            this.subjectsListView.TabIndex = 29;
            this.subjectsListView.UseCompatibleStateImageBehavior = false;
            this.subjectsListView.View = System.Windows.Forms.View.Details;
            this.subjectsListView.SelectedIndexChanged += new System.EventHandler(this.subjectsListView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Предмет";
            this.columnHeader4.Width = 130;
            // 
            // sessionsListView
            // 
            this.sessionsListView.BackColor = System.Drawing.SystemColors.Window;
            this.sessionsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sessionsListView.CheckBoxes = true;
            this.sessionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.sessionsListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sessionsListView.FullRowSelect = true;
            this.sessionsListView.GridLines = true;
            this.sessionsListView.HideSelection = false;
            this.sessionsListView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.sessionsListView.Location = new System.Drawing.Point(48, 25);
            this.sessionsListView.Margin = new System.Windows.Forms.Padding(1);
            this.sessionsListView.MultiSelect = false;
            this.sessionsListView.Name = "sessionsListView";
            this.sessionsListView.Scrollable = false;
            this.sessionsListView.Size = new System.Drawing.Size(94, 131);
            this.sessionsListView.TabIndex = 30;
            this.sessionsListView.UseCompatibleStateImageBehavior = false;
            this.sessionsListView.View = System.Windows.Forms.View.Details;
            this.sessionsListView.SelectedIndexChanged += new System.EventHandler(this.sessionsListView_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Сессия";
            this.columnHeader6.Width = 130;
            // 
            // studentsListView
            // 
            this.studentsListView.AutoArrange = false;
            this.studentsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentsListView.CheckBoxes = true;
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.idColumn,
            this.nameColumn,
            this.assessmentColumn});
            this.studentsListView.GridLines = true;
            this.studentsListView.Location = new System.Drawing.Point(274, 185);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(1);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Scrollable = false;
            this.studentsListView.Size = new System.Drawing.Size(405, 246);
            this.studentsListView.TabIndex = 31;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            this.studentsListView.SelectedIndexChanged += new System.EventHandler(this.studentsListView_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 29;
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.Width = 94;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Фио";
            this.nameColumn.Width = 200;
            // 
            // assessmentColumn
            // 
            this.assessmentColumn.Text = "Оценка";
            this.assessmentColumn.Width = 74;
            // 
            // newSessionButton
            // 
            this.newSessionButton.Enabled = false;
            this.newSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSessionButton.Location = new System.Drawing.Point(144, 96);
            this.newSessionButton.Margin = new System.Windows.Forms.Padding(1);
            this.newSessionButton.Name = "newSessionButton";
            this.newSessionButton.Size = new System.Drawing.Size(80, 29);
            this.newSessionButton.TabIndex = 32;
            this.newSessionButton.Text = "Добавить";
            this.newSessionButton.UseVisualStyleBackColor = true;
            this.newSessionButton.Click += new System.EventHandler(this.newSessionButton_Click);
            // 
            // newSubjectButton
            // 
            this.newSubjectButton.Enabled = false;
            this.newSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSubjectButton.Location = new System.Drawing.Point(407, 96);
            this.newSubjectButton.Margin = new System.Windows.Forms.Padding(1);
            this.newSubjectButton.Name = "newSubjectButton";
            this.newSubjectButton.Size = new System.Drawing.Size(81, 29);
            this.newSubjectButton.TabIndex = 33;
            this.newSubjectButton.Text = "Добавить";
            this.newSubjectButton.UseVisualStyleBackColor = true;
            this.newSubjectButton.Click += new System.EventHandler(this.newSubjectBbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(548, 25);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 29);
            this.cancelButton.TabIndex = 34;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // removeSessionButton
            // 
            this.removeSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeSessionButton.Location = new System.Drawing.Point(144, 127);
            this.removeSessionButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeSessionButton.Name = "removeSessionButton";
            this.removeSessionButton.Size = new System.Drawing.Size(80, 29);
            this.removeSessionButton.TabIndex = 35;
            this.removeSessionButton.Text = "Удалить";
            this.removeSessionButton.UseVisualStyleBackColor = true;
            this.removeSessionButton.Click += new System.EventHandler(this.removeSessionButton_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.removeSessionButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.newSubjectButton);
            this.Controls.Add(this.newSessionButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.sessionsListView);
            this.Controls.Add(this.subjectsListView);
            this.Controls.Add(this.groupListView);
            this.Controls.Add(this.removeSubjecttButton);
            this.Name = "SessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SessionFrom";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button removeSubjecttButton;
        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ListView subjectsListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView sessionsListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader assessmentColumn;
        private System.Windows.Forms.Button newSessionButton;
        private System.Windows.Forms.Button newSubjectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeSessionButton;
    }
}