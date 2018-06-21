namespace UI
{
    partial class Exam
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._homeButton = new System.Windows.Forms.Button();
            this._nameTeacherComboBox = new System.Windows.Forms.ComboBox();
            this._createSubjectbutton = new System.Windows.Forms.Button();
            this.StudentGroupDataGridView = new System.Windows.Forms.DataGridView();
            this.NameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboutExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._homeButton);
            this.panel1.Controls.Add(this._nameTeacherComboBox);
            this.panel1.Controls.Add(this._createSubjectbutton);
            this.panel1.Location = new System.Drawing.Point(20, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 114);
            this.panel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Примечание";
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
            // 
            // _nameTeacherComboBox
            // 
            this._nameTeacherComboBox.FormattingEnabled = true;
            this._nameTeacherComboBox.Location = new System.Drawing.Point(315, 14);
            this._nameTeacherComboBox.Name = "_nameTeacherComboBox";
            this._nameTeacherComboBox.Size = new System.Drawing.Size(112, 21);
            this._nameTeacherComboBox.TabIndex = 10;
            // 
            // _createSubjectbutton
            // 
            this._createSubjectbutton.Location = new System.Drawing.Point(315, 80);
            this._createSubjectbutton.Name = "_createSubjectbutton";
            this._createSubjectbutton.Size = new System.Drawing.Size(112, 27);
            this._createSubjectbutton.TabIndex = 9;
            this._createSubjectbutton.Text = "Добавить";
            this._createSubjectbutton.UseVisualStyleBackColor = true;
            this._createSubjectbutton.Click += new System.EventHandler(this._createSubjectbutton_Click);
            // 
            // StudentGroupDataGridView
            // 
            this.StudentGroupDataGridView.AllowUserToAddRows = false;
            this.StudentGroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGroupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameStudent,
            this.Group,
            this.AboutExam});
            this.StudentGroupDataGridView.Location = new System.Drawing.Point(20, 12);
            this.StudentGroupDataGridView.Name = "StudentGroupDataGridView";
            this.StudentGroupDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StudentGroupDataGridView.Size = new System.Drawing.Size(435, 299);
            this.StudentGroupDataGridView.TabIndex = 29;
            // 
            // NameStudent
            // 
            this.NameStudent.HeaderText = "Студент";
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.ReadOnly = true;
            this.NameStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameStudent.Width = 210;
            // 
            // Group
            // 
            this.Group.HeaderText = "Результат";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Group.Width = 80;
            // 
            // AboutExam
            // 
            this.AboutExam.HeaderText = "Примечание";
            this.AboutExam.Name = "AboutExam";
            this.AboutExam.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Преподаватель";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 20);
            this.textBox2.TabIndex = 43;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Результат";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StudentGroupDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экзамен";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGroupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _homeButton;
        private System.Windows.Forms.ComboBox _nameTeacherComboBox;
        private System.Windows.Forms.Button _createSubjectbutton;
        private System.Windows.Forms.DataGridView StudentGroupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn AboutExam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}