namespace Lab4.View
{
    partial class GroupsForm
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
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.newGroupButton = new System.Windows.Forms.Button();
            this.groupListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateBirthdayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeStudentButton.Location = new System.Drawing.Point(606, 404);
            this.removeStudentButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(82, 29);
            this.removeStudentButton.TabIndex = 16;
            this.removeStudentButton.Text = "Удалить";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // newStudentButton
            // 
            this.newStudentButton.Enabled = false;
            this.newStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newStudentButton.Location = new System.Drawing.Point(515, 403);
            this.newStudentButton.Margin = new System.Windows.Forms.Padding(1);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(89, 29);
            this.newStudentButton.TabIndex = 14;
            this.newStudentButton.Text = "Добавить";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudentButton_Click);
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupButton.Location = new System.Drawing.Point(131, 403);
            this.removeGroupButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(72, 29);
            this.removeGroupButton.TabIndex = 17;
            this.removeGroupButton.Text = "Удалить";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // newGroupButton
            // 
            this.newGroupButton.Enabled = false;
            this.newGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGroupButton.Location = new System.Drawing.Point(43, 404);
            this.newGroupButton.Margin = new System.Windows.Forms.Padding(1);
            this.newGroupButton.Name = "newGroupButton";
            this.newGroupButton.Size = new System.Drawing.Size(86, 29);
            this.newGroupButton.TabIndex = 15;
            this.newGroupButton.Text = "Добавить";
            this.newGroupButton.UseVisualStyleBackColor = true;
            this.newGroupButton.Click += new System.EventHandler(this.newGroupButton_Click);
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
            this.groupListView.Location = new System.Drawing.Point(43, 87);
            this.groupListView.Margin = new System.Windows.Forms.Padding(1);
            this.groupListView.MultiSelect = false;
            this.groupListView.Name = "groupListView";
            this.groupListView.Scrollable = false;
            this.groupListView.Size = new System.Drawing.Size(160, 314);
            this.groupListView.TabIndex = 11;
            this.groupListView.UseCompatibleStateImageBehavior = false;
            this.groupListView.View = System.Windows.Forms.View.Details;
            this.groupListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.groupListView_ColumnWidthChanging);
            this.groupListView.SelectedIndexChanged += new System.EventHandler(this.groupListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // Group
            // 
            this.Group.Text = "Группа";
            this.Group.Width = 130;
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
            this.dateBirthdayColumn});
            this.studentsListView.GridLines = true;
            this.studentsListView.Location = new System.Drawing.Point(234, 87);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(1);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Scrollable = false;
            this.studentsListView.Size = new System.Drawing.Size(454, 314);
            this.studentsListView.TabIndex = 18;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            this.studentsListView.SelectedIndexChanged += new System.EventHandler(this.studentsListView_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            // 
            // idColumn
            // 
            this.idColumn.Text = "Id";
            this.idColumn.Width = 94;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Фио";
            this.nameColumn.Width = 195;
            // 
            // dateBirthdayColumn
            // 
            this.dateBirthdayColumn.Text = "Дата рождения";
            this.dateBirthdayColumn.Width = 100;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(557, 27);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 29);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // GroupsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(this.removeGroupButton);
            this.Controls.Add(this.newGroupButton);
            this.Controls.Add(this.groupListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groups";
            this.ResumeLayout(false);

        }

        #endregion


   
    //    private System.Windows.Forms.Button cancelButton;


        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.Button newGroupButton;
        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateBirthdayColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cancelButton;
    }
}