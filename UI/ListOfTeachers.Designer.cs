namespace UI
{
    partial class ListOfTeachers
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
            this._homeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._subjectsComboBox = new System.Windows.Forms.ComboBox();
            this._nextButton = new System.Windows.Forms.Button();
            this._femaleRadioButton = new System.Windows.Forms.RadioButton();
            this._maleRadioButton = new System.Windows.Forms.RadioButton();
            this._patromicTeacherTextBox = new System.Windows.Forms.TextBox();
            this._lastNameTeacherTextBox = new System.Windows.Forms.TextBox();
            this._removeButton = new System.Windows.Forms.Button();
            this._reverseButton = new System.Windows.Forms.Button();
            this._createButton = new System.Windows.Forms.Button();
            this.StudentGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListOfSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this._firstNameTeacherTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _homeButton
            // 
            this._homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._homeButton.Location = new System.Drawing.Point(8, 97);
            this._homeButton.Name = "_homeButton";
            this._homeButton.Size = new System.Drawing.Size(111, 27);
            this._homeButton.TabIndex = 41;
            this._homeButton.Text = "На главную";
            this._homeButton.UseVisualStyleBackColor = true;
            this._homeButton.Click += new System.EventHandler(this._homeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Назначить предмет";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Фамилия";
            // 
            // _subjectsComboBox
            // 
            this._subjectsComboBox.FormattingEnabled = true;
            this._subjectsComboBox.Location = new System.Drawing.Point(311, 102);
            this._subjectsComboBox.Name = "_subjectsComboBox";
            this._subjectsComboBox.Size = new System.Drawing.Size(111, 21);
            this._subjectsComboBox.TabIndex = 35;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(381, 282);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(75, 23);
            this._nextButton.TabIndex = 34;
            this._nextButton.Text = "Перейти";
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // _femaleRadioButton
            // 
            this._femaleRadioButton.AutoSize = true;
            this._femaleRadioButton.Location = new System.Drawing.Point(373, 42);
            this._femaleRadioButton.Name = "_femaleRadioButton";
            this._femaleRadioButton.Size = new System.Drawing.Size(36, 17);
            this._femaleRadioButton.TabIndex = 33;
            this._femaleRadioButton.TabStop = true;
            this._femaleRadioButton.Text = "Ж";
            this._femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // _maleRadioButton
            // 
            this._maleRadioButton.AutoSize = true;
            this._maleRadioButton.Location = new System.Drawing.Point(373, 20);
            this._maleRadioButton.Name = "_maleRadioButton";
            this._maleRadioButton.Size = new System.Drawing.Size(34, 17);
            this._maleRadioButton.TabIndex = 32;
            this._maleRadioButton.TabStop = true;
            this._maleRadioButton.Text = "М";
            this._maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // _patromicTeacherTextBox
            // 
            this._patromicTeacherTextBox.Location = new System.Drawing.Point(250, 27);
            this._patromicTeacherTextBox.Name = "_patromicTeacherTextBox";
            this._patromicTeacherTextBox.Size = new System.Drawing.Size(100, 20);
            this._patromicTeacherTextBox.TabIndex = 30;
            // 
            // _lastNameTeacherTextBox
            // 
            this._lastNameTeacherTextBox.Location = new System.Drawing.Point(10, 27);
            this._lastNameTeacherTextBox.Name = "_lastNameTeacherTextBox";
            this._lastNameTeacherTextBox.Size = new System.Drawing.Size(100, 20);
            this._lastNameTeacherTextBox.TabIndex = 28;
            this._lastNameTeacherTextBox.TextChanged += new System.EventHandler(this._lastNameTeacherTextBox_TextChanged);
            // 
            // _removeButton
            // 
            this._removeButton.Location = new System.Drawing.Point(300, 282);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(75, 23);
            this._removeButton.TabIndex = 27;
            this._removeButton.Text = "Удалить";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // _reverseButton
            // 
            this._reverseButton.Location = new System.Drawing.Point(218, 282);
            this._reverseButton.Name = "_reverseButton";
            this._reverseButton.Size = new System.Drawing.Size(75, 23);
            this._reverseButton.TabIndex = 26;
            this._reverseButton.Text = "Изменить";
            this._reverseButton.UseVisualStyleBackColor = true;
            // 
            // _createButton
            // 
            this._createButton.Location = new System.Drawing.Point(309, 68);
            this._createButton.Name = "_createButton";
            this._createButton.Size = new System.Drawing.Size(113, 27);
            this._createButton.TabIndex = 25;
            this._createButton.Text = "Добавить";
            this._createButton.UseVisualStyleBackColor = true;
            this._createButton.Click += new System.EventHandler(this._createButton_Click);
            // 
            // StudentGroupDataGridView
            // 
            this.StudentGroupDataGridView.AllowUserToAddRows = false;
            this.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NameStudent,
            this.Gender,
            this.ListOfSubjects});
            this.StudentGroupDataGridView.Location = new System.Drawing.Point(21, 16);
            this.StudentGroupDataGridView.Name = "StudentGroupDataGridView";
            this.StudentGroupDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentGroupDataGridView.Size = new System.Drawing.Size(435, 262);
            this.StudentGroupDataGridView.TabIndex = 24;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.Width = 50;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "ФИО";
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.ReadOnly = true;
            this.NameStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameStudent.Width = 210;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gender.Width = 50;
            // 
            // ListOfSubjects
            // 
            this.ListOfSubjects.HeaderText = "Предмет";
            this.ListOfSubjects.Name = "ListOfSubjects";
            this.ListOfSubjects.ReadOnly = true;
            this.ListOfSubjects.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ListOfSubjects.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this._homeButton);
            this.panel1.Controls.Add(this._createButton);
            this.panel1.Controls.Add(this._femaleRadioButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._subjectsComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._maleRadioButton);
            this.panel1.Controls.Add(this._patromicTeacherTextBox);
            this.panel1.Controls.Add(this._firstNameTeacherTextBox);
            this.panel1.Controls.Add(this._lastNameTeacherTextBox);
            this.panel1.Location = new System.Drawing.Point(21, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 130);
            this.panel1.TabIndex = 45;
            // 
            // _firstNameTeacherTextBox
            // 
            this._firstNameTeacherTextBox.Location = new System.Drawing.Point(131, 27);
            this._firstNameTeacherTextBox.Name = "_firstNameTeacherTextBox";
            this._firstNameTeacherTextBox.Size = new System.Drawing.Size(100, 20);
            this._firstNameTeacherTextBox.TabIndex = 29;
            // 
            // ListOfTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._removeButton);
            this.Controls.Add(this._reverseButton);
            this.Controls.Add(this.StudentGroupDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListOfTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список учителей";
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _homeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _subjectsComboBox;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.RadioButton _femaleRadioButton;
        private System.Windows.Forms.RadioButton _maleRadioButton;
        private System.Windows.Forms.TextBox _patromicTeacherTextBox;
        private System.Windows.Forms.TextBox _lastNameTeacherTextBox;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Button _reverseButton;
        private System.Windows.Forms.Button _createButton;
        private System.Windows.Forms.DataGridView StudentGroupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListOfSubjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox _firstNameTeacherTextBox;
    }
}