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
            this.UnivercityInfoTextBox = new System.Windows.Forms.TextBox();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentsListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateBirthdayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.initButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeStudentButton.Location = new System.Drawing.Point(193, 411);
            this.removeStudentButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(131, 29);
            this.removeStudentButton.TabIndex = 16;
            this.removeStudentButton.Text = "Удалить";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            // 
            // newStudentButton
            // 
            this.newStudentButton.Enabled = false;
            this.newStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newStudentButton.Location = new System.Drawing.Point(410, 404);
            this.newStudentButton.Margin = new System.Windows.Forms.Padding(1);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(131, 29);
            this.newStudentButton.TabIndex = 14;
            this.newStudentButton.Text = "Добавить";
            this.newStudentButton.UseVisualStyleBackColor = true;
            this.newStudentButton.Click += new System.EventHandler(this.newStudentButton_Click_1);
            // 
            // UnivercityInfoTextBox
            // 
            this.UnivercityInfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UnivercityInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnivercityInfoTextBox.Location = new System.Drawing.Point(43, 27);
            this.UnivercityInfoTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.UnivercityInfoTextBox.Multiline = true;
            this.UnivercityInfoTextBox.Name = "UnivercityInfoTextBox";
            this.UnivercityInfoTextBox.ReadOnly = true;
            this.UnivercityInfoTextBox.Size = new System.Drawing.Size(544, 31);
            this.UnivercityInfoTextBox.TabIndex = 13;
            this.UnivercityInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupButton.Location = new System.Drawing.Point(564, 404);
            this.removeGroupButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(124, 29);
            this.removeGroupButton.TabIndex = 17;
            this.removeGroupButton.Text = "Удалить";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Enabled = false;
            this.addGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupButton.Location = new System.Drawing.Point(43, 404);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(1);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(124, 29);
            this.addGroupButton.TabIndex = 15;
            this.addGroupButton.Text = "Добавить";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // groupListView
            // 
            this.groupListView.BackColor = System.Drawing.SystemColors.Window;
            this.groupListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupListView.CheckBoxes = true;
            this.groupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Group,
            this.PhoneNumber});
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
            this.groupListView.Size = new System.Drawing.Size(124, 314);
            this.groupListView.TabIndex = 11;
            this.groupListView.UseCompatibleStateImageBehavior = false;
            this.groupListView.View = System.Windows.Forms.View.Details;
            this.groupListView.SelectedIndexChanged += new System.EventHandler(this.groupListView_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "";
            // 
            // Group
            // 
            this.Group.DisplayIndex = 0;
            this.Group.Text = "Группа";
            this.Group.Width = 130;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DisplayIndex = 1;
            this.PhoneNumber.Text = "PhoneNumber";
            this.PhoneNumber.Width = 150;
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
            this.studentsListView.Location = new System.Drawing.Point(217, 87);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(1);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Scrollable = false;
            this.studentsListView.Size = new System.Drawing.Size(471, 314);
            this.studentsListView.TabIndex = 18;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            this.studentsListView.SelectedIndexChanged += new System.EventHandler(this.studentsListView_SelectedIndexChanged_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 3;
            this.columnHeader2.Text = "";
            // 
            // idColumn
            // 
            this.idColumn.DisplayIndex = 0;
            this.idColumn.Text = "Id";
            this.idColumn.Width = 94;
            // 
            // nameColumn
            // 
            this.nameColumn.DisplayIndex = 1;
            this.nameColumn.Text = "Фио";
            this.nameColumn.Width = 200;
            // 
            // dateBirthdayColumn
            // 
            this.dateBirthdayColumn.DisplayIndex = 2;
            this.dateBirthdayColumn.Text = "Дата рождения";
            this.dateBirthdayColumn.Width = 100;
            // 
            // initButton
            // 
            this.initButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.initButton.Location = new System.Drawing.Point(607, 27);
            this.initButton.Margin = new System.Windows.Forms.Padding(1);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(81, 29);
            this.initButton.TabIndex = 19;
            this.initButton.Text = "Тест";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(this.UnivercityInfoTextBox);
            this.Controls.Add(this.removeGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.groupListView);
            this.Name = "GroupsForm";
            this.Text = "Groups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


   
    //    private System.Windows.Forms.Button cancelButton;


        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.TextBox UnivercityInfoTextBox;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateBirthdayColumn;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}