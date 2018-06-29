namespace Lab2.View
{
    partial class SessionFrom
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
            this.initButton = new System.Windows.Forms.Button();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateBirthdayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.newStudentButton = new System.Windows.Forms.Button();
            this.UnivercityInfoTextBox = new System.Windows.Forms.TextBox();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeSpecialtyComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.initButton.Location = new System.Drawing.Point(642, 19);
            this.initButton.Margin = new System.Windows.Forms.Padding(1);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(81, 29);
            this.initButton.TabIndex = 27;
            this.initButton.Text = "Тест";
            this.initButton.UseVisualStyleBackColor = true;
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
            this.studentsListView.Location = new System.Drawing.Point(382, 79);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(1);
            this.studentsListView.MultiSelect = false;
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Scrollable = false;
            this.studentsListView.Size = new System.Drawing.Size(341, 314);
            this.studentsListView.TabIndex = 26;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            // 
            // idColumn
            // 
            this.idColumn.DisplayIndex = 0;
            this.idColumn.Text = "Id";
            this.idColumn.Width = 35;
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
            // removeStudentButton
            // 
            this.removeStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeStudentButton.Location = new System.Drawing.Point(228, 400);
            this.removeStudentButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(131, 29);
            this.removeStudentButton.TabIndex = 24;
            this.removeStudentButton.Text = "Удалить";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            // 
            // newStudentButton
            // 
            this.newStudentButton.Enabled = false;
            this.newStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newStudentButton.Location = new System.Drawing.Point(445, 400);
            this.newStudentButton.Margin = new System.Windows.Forms.Padding(1);
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.Size = new System.Drawing.Size(131, 29);
            this.newStudentButton.TabIndex = 22;
            this.newStudentButton.Text = "Добавить";
            this.newStudentButton.UseVisualStyleBackColor = true;
            // 
            // UnivercityInfoTextBox
            // 
            this.UnivercityInfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UnivercityInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnivercityInfoTextBox.Location = new System.Drawing.Point(78, 19);
            this.UnivercityInfoTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.UnivercityInfoTextBox.Multiline = true;
            this.UnivercityInfoTextBox.Name = "UnivercityInfoTextBox";
            this.UnivercityInfoTextBox.ReadOnly = true;
            this.UnivercityInfoTextBox.Size = new System.Drawing.Size(544, 31);
            this.UnivercityInfoTextBox.TabIndex = 21;
            this.UnivercityInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupButton.Location = new System.Drawing.Point(599, 400);
            this.removeGroupButton.Margin = new System.Windows.Forms.Padding(1);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(124, 29);
            this.removeGroupButton.TabIndex = 25;
            this.removeGroupButton.Text = "Удалить";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Enabled = false;
            this.addGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupButton.Location = new System.Drawing.Point(78, 396);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(1);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(124, 29);
            this.addGroupButton.TabIndex = 23;
            this.addGroupButton.Text = "Добавить";
            this.addGroupButton.UseVisualStyleBackColor = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 3;
            this.columnHeader2.Text = "";
            // 
            // codeSpecialtyComboBox
            // 
            this.codeSpecialtyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeSpecialtyComboBox.FormattingEnabled = true;
            this.codeSpecialtyComboBox.Location = new System.Drawing.Point(78, 104);
            this.codeSpecialtyComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.codeSpecialtyComboBox.Name = "codeSpecialtyComboBox";
            this.codeSpecialtyComboBox.Size = new System.Drawing.Size(182, 21);
            this.codeSpecialtyComboBox.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 241);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(75, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Сессия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(75, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(75, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Группа";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(78, 175);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 33;
            // 
            // SessionFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.codeSpecialtyComboBox);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.newStudentButton);
            this.Controls.Add(this.UnivercityInfoTextBox);
            this.Controls.Add(this.removeGroupButton);
            this.Controls.Add(this.addGroupButton);
            this.Name = "SessionFrom";
            this.Text = "SessionFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dateBirthdayColumn;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button newStudentButton;
        private System.Windows.Forms.TextBox UnivercityInfoTextBox;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox codeSpecialtyComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}