﻿namespace UI
{
    partial class Enrollee

    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._createButton = new System.Windows.Forms.Button();
            this._reverseButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._lastNameStudentTextBox = new System.Windows.Forms.TextBox();
            this._patromicStudentTextBox = new System.Windows.Forms.TextBox();
            this._firstNameStudentTextBox = new System.Windows.Forms.TextBox();
            this._maleRadioButton = new System.Windows.Forms.RadioButton();
            this._femaleRadioButton = new System.Windows.Forms.RadioButton();
            this._nextButton = new System.Windows.Forms.Button();
            this._studentGroupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._homeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGroupDataGridView
            // 
            this.StudentGroupDataGridView.AllowUserToAddRows = false;
            this.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NameStudent,
            this.Gender,
            this.Group});
            this.StudentGroupDataGridView.Location = new System.Drawing.Point(21, 16);
            this.StudentGroupDataGridView.Name = "StudentGroupDataGridView";
            this.StudentGroupDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentGroupDataGridView.Size = new System.Drawing.Size(435, 262);
            this.StudentGroupDataGridView.TabIndex = 0;
            this.StudentGroupDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Group.Width = 80;
            // 
            // _createButton
            // 
            this._createButton.Location = new System.Drawing.Point(305, 68);
            this._createButton.Name = "_createButton";
            this._createButton.Size = new System.Drawing.Size(115, 27);
            this._createButton.TabIndex = 6;
            this._createButton.Text = "Добавить";
            this._createButton.UseVisualStyleBackColor = true;
            this._createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // _reverseButton
            // 
            this._reverseButton.Location = new System.Drawing.Point(217, 282);
            this._reverseButton.Name = "_reverseButton";
            this._reverseButton.Size = new System.Drawing.Size(75, 23);
            this._reverseButton.TabIndex = 7;
            this._reverseButton.Text = "Изменить";
            this._reverseButton.UseVisualStyleBackColor = true;
            // 
            // _removeButton
            // 
            this._removeButton.Location = new System.Drawing.Point(299, 282);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(75, 23);
            this._removeButton.TabIndex = 8;
            this._removeButton.Text = "Удалить";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // _lastNameStudentTextBox
            // 
            this._lastNameStudentTextBox.Location = new System.Drawing.Point(11, 26);
            this._lastNameStudentTextBox.Name = "_lastNameStudentTextBox";
            this._lastNameStudentTextBox.Size = new System.Drawing.Size(100, 20);
            this._lastNameStudentTextBox.TabIndex = 9;
            this._lastNameStudentTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // _patromicStudentTextBox
            // 
            this._patromicStudentTextBox.Location = new System.Drawing.Point(250, 26);
            this._patromicStudentTextBox.Name = "_patromicStudentTextBox";
            this._patromicStudentTextBox.Size = new System.Drawing.Size(100, 20);
            this._patromicStudentTextBox.TabIndex = 11;
            // 
            // _firstNameStudentTextBox
            // 
            this._firstNameStudentTextBox.Location = new System.Drawing.Point(131, 26);
            this._firstNameStudentTextBox.Name = "_firstNameStudentTextBox";
            this._firstNameStudentTextBox.Size = new System.Drawing.Size(100, 20);
            this._firstNameStudentTextBox.TabIndex = 10;
            // 
            // _maleRadioButton
            // 
            this._maleRadioButton.AutoSize = true;
            this._maleRadioButton.Location = new System.Drawing.Point(374, 19);
            this._maleRadioButton.Name = "_maleRadioButton";
            this._maleRadioButton.Size = new System.Drawing.Size(34, 17);
            this._maleRadioButton.TabIndex = 14;
            this._maleRadioButton.TabStop = true;
            this._maleRadioButton.Text = "М";
            this._maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // _femaleRadioButton
            // 
            this._femaleRadioButton.AutoSize = true;
            this._femaleRadioButton.Location = new System.Drawing.Point(374, 42);
            this._femaleRadioButton.Name = "_femaleRadioButton";
            this._femaleRadioButton.Size = new System.Drawing.Size(36, 17);
            this._femaleRadioButton.TabIndex = 15;
            this._femaleRadioButton.TabStop = true;
            this._femaleRadioButton.Text = "Ж";
            this._femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(381, 282);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(75, 23);
            this._nextButton.TabIndex = 16;
            this._nextButton.Text = "Перейти";
            this._nextButton.UseVisualStyleBackColor = true;
            this._nextButton.Click += new System.EventHandler(this._nextButton_Click);
            // 
            // _studentGroupComboBox
            // 
            this._studentGroupComboBox.FormattingEnabled = true;
            this._studentGroupComboBox.Location = new System.Drawing.Point(305, 101);
            this._studentGroupComboBox.Name = "_studentGroupComboBox";
            this._studentGroupComboBox.Size = new System.Drawing.Size(115, 21);
            this._studentGroupComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Назначить в группу";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // _homeButton
            // 
            this._homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._homeButton.Location = new System.Drawing.Point(7, 96);
            this._homeButton.Name = "_homeButton";
            this._homeButton.Size = new System.Drawing.Size(111, 27);
            this._homeButton.TabIndex = 23;
            this._homeButton.Text = "На главную";
            this._homeButton.UseVisualStyleBackColor = true;
            this._homeButton.Click += new System.EventHandler(this._homeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._homeButton);
            this.panel1.Controls.Add(this._createButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._lastNameStudentTextBox);
            this.panel1.Controls.Add(this._studentGroupComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._firstNameStudentTextBox);
            this.panel1.Controls.Add(this._patromicStudentTextBox);
            this.panel1.Controls.Add(this._maleRadioButton);
            this.panel1.Controls.Add(this._femaleRadioButton);
            this.panel1.Location = new System.Drawing.Point(21, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 130);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Enrollee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentGroupDataGridView);
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._reverseButton);
            this.Controls.Add(this._removeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Enrollee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список абитуриентов";
            this.Load += new System.EventHandler(this.StudenGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGroupDataGridView;
        private System.Windows.Forms.Button _createButton;
        private System.Windows.Forms.Button _reverseButton;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.TextBox _lastNameStudentTextBox;
        private System.Windows.Forms.TextBox _patromicStudentTextBox;
        private System.Windows.Forms.TextBox _firstNameStudentTextBox;
        private System.Windows.Forms.RadioButton _maleRadioButton;
        private System.Windows.Forms.RadioButton _femaleRadioButton;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.ComboBox _studentGroupComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _homeButton;
        private System.Windows.Forms.Panel panel1;
    }
}
