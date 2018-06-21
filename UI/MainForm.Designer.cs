namespace UI
{
    partial class MainForm
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
            this._createEnrolleeButton = new System.Windows.Forms.Button();
            this._listOfStudentGroupsButton = new System.Windows.Forms.Button();
            this._listOfSubjectsButton = new System.Windows.Forms.Button();
            this.listOfTeachersButton = new System.Windows.Forms.Button();
            this._listOfSessionsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _createEnrolleeButton
            // 
            this._createEnrolleeButton.Location = new System.Drawing.Point(52, 25);
            this._createEnrolleeButton.Name = "_createEnrolleeButton";
            this._createEnrolleeButton.Size = new System.Drawing.Size(150, 39);
            this._createEnrolleeButton.TabIndex = 0;
            this._createEnrolleeButton.Text = "Добавить абитуриента";
            this._createEnrolleeButton.UseVisualStyleBackColor = true;
            this._createEnrolleeButton.Click += new System.EventHandler(this._createEnrolleeButton_Click);
            // 
            // _listOfStudentGroupsButton
            // 
            this._listOfStudentGroupsButton.Location = new System.Drawing.Point(52, 87);
            this._listOfStudentGroupsButton.Name = "_listOfStudentGroupsButton";
            this._listOfStudentGroupsButton.Size = new System.Drawing.Size(150, 37);
            this._listOfStudentGroupsButton.TabIndex = 1;
            this._listOfStudentGroupsButton.Text = "Список  групп";
            this._listOfStudentGroupsButton.UseVisualStyleBackColor = true;
            this._listOfStudentGroupsButton.Click += new System.EventHandler(this._listOfStudentGroupsButton_Click);
            // 
            // _listOfSubjectsButton
            // 
            this._listOfSubjectsButton.Location = new System.Drawing.Point(52, 146);
            this._listOfSubjectsButton.Name = "_listOfSubjectsButton";
            this._listOfSubjectsButton.Size = new System.Drawing.Size(150, 39);
            this._listOfSubjectsButton.TabIndex = 2;
            this._listOfSubjectsButton.Text = "Список предметов";
            this._listOfSubjectsButton.UseVisualStyleBackColor = true;
            this._listOfSubjectsButton.Click += new System.EventHandler(this._listOfSubjectsButton_Click);
            // 
            // listOfTeachersButton
            // 
            this.listOfTeachersButton.Location = new System.Drawing.Point(52, 208);
            this.listOfTeachersButton.Name = "listOfTeachersButton";
            this.listOfTeachersButton.Size = new System.Drawing.Size(150, 40);
            this.listOfTeachersButton.TabIndex = 3;
            this.listOfTeachersButton.Text = "Список преподавателей";
            this.listOfTeachersButton.UseVisualStyleBackColor = true;
            this.listOfTeachersButton.Click += new System.EventHandler(this.listOfTeachersButton_Click);
            // 
            // _listOfSessionsButton
            // 
            this._listOfSessionsButton.Location = new System.Drawing.Point(52, 268);
            this._listOfSessionsButton.Name = "_listOfSessionsButton";
            this._listOfSessionsButton.Size = new System.Drawing.Size(150, 37);
            this._listOfSessionsButton.TabIndex = 4;
            this._listOfSessionsButton.Text = "Сессия";
            this._listOfSessionsButton.UseVisualStyleBackColor = true;
            this._listOfSessionsButton.Click += new System.EventHandler(this._listOfSessionsButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this._createEnrolleeButton);
            this.panel1.Controls.Add(this._listOfSessionsButton);
            this.panel1.Controls.Add(this._listOfStudentGroupsButton);
            this.panel1.Controls.Add(this.listOfTeachersButton);
            this.panel1.Controls.Add(this._listOfSubjectsButton);
            this.panel1.Location = new System.Drawing.Point(114, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 333);
            this.panel1.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _createEnrolleeButton;
        private System.Windows.Forms.Button _listOfStudentGroupsButton;
        private System.Windows.Forms.Button _listOfSubjectsButton;
        private System.Windows.Forms.Button listOfTeachersButton;
        private System.Windows.Forms.Button _listOfSessionsButton;
        private System.Windows.Forms.Panel panel1;
    }
}