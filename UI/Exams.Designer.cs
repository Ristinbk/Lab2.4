namespace UI
{
    partial class Exams
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
            this.StudentGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Предмет = new System.Windows.Forms.Label();
            this._subjectTextBox = new System.Windows.Forms.TextBox();
            this._creditRadioButton = new System.Windows.Forms.RadioButton();
            this._examRadioButton = new System.Windows.Forms.RadioButton();
            this._createSubjectbutton = new System.Windows.Forms.Button();
            this._nameTeacherComboBox = new System.Windows.Forms.ComboBox();
            this._homeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._nextButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._reverseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGroupDataGridView
            // 
            this.StudentGroupDataGridView.AllowUserToAddRows = false;
            this.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gender,
            this.NameStudent,
            this.Group});
            this.StudentGroupDataGridView.Location = new System.Drawing.Point(21, 25);
            this.StudentGroupDataGridView.Name = "StudentGroupDataGridView";
            this.StudentGroupDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentGroupDataGridView.Size = new System.Drawing.Size(435, 262);
            this.StudentGroupDataGridView.TabIndex = 1;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Предмет";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "Преподаватель";
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.ReadOnly = true;
            this.NameStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameStudent.Width = 210;
            // 
            // Group
            // 
            this.Group.HeaderText = "Тип";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Group.Width = 80;
            // 
            // Предмет
            // 
            this.Предмет.AutoSize = true;
            this.Предмет.Location = new System.Drawing.Point(3, 9);
            this.Предмет.Name = "Предмет";
            this.Предмет.Size = new System.Drawing.Size(52, 13);
            this.Предмет.TabIndex = 2;
            this.Предмет.Text = "Предмет";
            // 
            // _subjectTextBox
            // 
            this._subjectTextBox.Location = new System.Drawing.Point(7, 29);
            this._subjectTextBox.Name = "_subjectTextBox";
            this._subjectTextBox.Size = new System.Drawing.Size(100, 20);
            this._subjectTextBox.TabIndex = 5;
            // 
            // _creditRadioButton
            // 
            this._creditRadioButton.AutoSize = true;
            this._creditRadioButton.Location = new System.Drawing.Point(165, 12);
            this._creditRadioButton.Name = "_creditRadioButton";
            this._creditRadioButton.Size = new System.Drawing.Size(54, 17);
            this._creditRadioButton.TabIndex = 7;
            this._creditRadioButton.TabStop = true;
            this._creditRadioButton.Text = "Зачёт";
            this._creditRadioButton.UseVisualStyleBackColor = true;
            // 
            // _examRadioButton
            // 
            this._examRadioButton.AutoSize = true;
            this._examRadioButton.Location = new System.Drawing.Point(165, 31);
            this._examRadioButton.Name = "_examRadioButton";
            this._examRadioButton.Size = new System.Drawing.Size(70, 17);
            this._examRadioButton.TabIndex = 8;
            this._examRadioButton.TabStop = true;
            this._examRadioButton.Text = "Экзамен";
            this._examRadioButton.UseVisualStyleBackColor = true;
            // 
            // _createSubjectbutton
            // 
            this._createSubjectbutton.Location = new System.Drawing.Point(315, 24);
            this._createSubjectbutton.Name = "_createSubjectbutton";
            this._createSubjectbutton.Size = new System.Drawing.Size(112, 27);
            this._createSubjectbutton.TabIndex = 9;
            this._createSubjectbutton.Text = "Добавить";
            this._createSubjectbutton.UseVisualStyleBackColor = true;
            this._createSubjectbutton.Click += new System.EventHandler(this._createSubjectbutton_Click);
            // 
            // _nameTeacherComboBox
            // 
            this._nameTeacherComboBox.FormattingEnabled = true;
            this._nameTeacherComboBox.Location = new System.Drawing.Point(315, 82);
            this._nameTeacherComboBox.Name = "_nameTeacherComboBox";
            this._nameTeacherComboBox.Size = new System.Drawing.Size(112, 21);
            this._nameTeacherComboBox.TabIndex = 10;
            this._nameTeacherComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _homeButton
            // 
            this._homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._homeButton.Location = new System.Drawing.Point(6, 79);
            this._homeButton.Name = "_homeButton";
            this._homeButton.Size = new System.Drawing.Size(111, 27);
            this._homeButton.TabIndex = 24;
            this._homeButton.Text = "На главную";
            this._homeButton.UseVisualStyleBackColor = true;
            this._homeButton.Click += new System.EventHandler(this._homeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._subjectTextBox);
            this.panel1.Controls.Add(this._homeButton);
            this.panel1.Controls.Add(this.Предмет);
            this.panel1.Controls.Add(this._nameTeacherComboBox);
            this.panel1.Controls.Add(this._createSubjectbutton);
            this.panel1.Controls.Add(this._creditRadioButton);
            this.panel1.Controls.Add(this._examRadioButton);
            this.panel1.Location = new System.Drawing.Point(21, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 114);
            this.panel1.TabIndex = 25;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(381, 293);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(75, 23);
            this._nextButton.TabIndex = 28;
            this._nextButton.Text = "Перейти";
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // _removeButton
            // 
            this._removeButton.Location = new System.Drawing.Point(297, 293);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(75, 23);
            this._removeButton.TabIndex = 27;
            this._removeButton.Text = "Удалить";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // _reverseButton
            // 
            this._reverseButton.Location = new System.Drawing.Point(213, 293);
            this._reverseButton.Name = "_reverseButton";
            this._reverseButton.Size = new System.Drawing.Size(75, 23);
            this._reverseButton.TabIndex = 26;
            this._reverseButton.Text = "Изменить";
            this._reverseButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Назначить учителя";
            // 
            // Exams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._removeButton);
            this.Controls.Add(this._reverseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentGroupDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список предметов";
            this.Load += new System.EventHandler(this.Exams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentGroupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.Label Предмет;
        private System.Windows.Forms.TextBox _subjectTextBox;
        private System.Windows.Forms.RadioButton _creditRadioButton;
        private System.Windows.Forms.RadioButton _examRadioButton;
        private System.Windows.Forms.Button _createSubjectbutton;
        private System.Windows.Forms.ComboBox _nameTeacherComboBox;
        private System.Windows.Forms.Button _homeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Button _reverseButton;
        private System.Windows.Forms.Label label5;
    }
}