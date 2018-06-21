namespace UI
{
    partial class ListOfStudentGroups
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
            this.ListOfStudentGroupsDataGridView = new System.Windows.Forms.DataGridView();
            this._nextButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._reverseButton = new System.Windows.Forms.Button();
            this._createGroupButton = new System.Windows.Forms.Button();
            this._homeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._groupComboBox = new System.Windows.Forms.ComboBox();
            this.NumberGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbouGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numberGroupTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfStudentGroupsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfStudentGroupsDataGridView
            // 
            this.ListOfStudentGroupsDataGridView.AllowUserToAddRows = false;
            this.ListOfStudentGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfStudentGroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberGroup,
            this.AbouGroup});
            this.ListOfStudentGroupsDataGridView.Location = new System.Drawing.Point(20, 23);
            this.ListOfStudentGroupsDataGridView.Name = "ListOfStudentGroupsDataGridView";
            this.ListOfStudentGroupsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ListOfStudentGroupsDataGridView.Size = new System.Drawing.Size(434, 250);
            this.ListOfStudentGroupsDataGridView.TabIndex = 0;
            // 
            // _nextButton
            // 
            this._nextButton.Location = new System.Drawing.Point(379, 279);
            this._nextButton.Name = "_nextButton";
            this._nextButton.Size = new System.Drawing.Size(75, 23);
            this._nextButton.TabIndex = 21;
            this._nextButton.Text = "Перейти";
            this._nextButton.UseVisualStyleBackColor = true;
            // 
            // _removeButton
            // 
            this._removeButton.Location = new System.Drawing.Point(295, 279);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(75, 23);
            this._removeButton.TabIndex = 19;
            this._removeButton.Text = "Удалить";
            this._removeButton.UseVisualStyleBackColor = true;
            // 
            // _reverseButton
            // 
            this._reverseButton.Location = new System.Drawing.Point(211, 279);
            this._reverseButton.Name = "_reverseButton";
            this._reverseButton.Size = new System.Drawing.Size(75, 23);
            this._reverseButton.TabIndex = 18;
            this._reverseButton.Text = "Изменить";
            this._reverseButton.UseVisualStyleBackColor = true;
            // 
            // _createGroupButton
            // 
            this._createGroupButton.Location = new System.Drawing.Point(298, 20);
            this._createGroupButton.Name = "_createGroupButton";
            this._createGroupButton.Size = new System.Drawing.Size(124, 27);
            this._createGroupButton.TabIndex = 17;
            this._createGroupButton.Text = "Добавить";
            this._createGroupButton.UseVisualStyleBackColor = true;
            this._createGroupButton.Click += new System.EventHandler(this._createGroupButton_Click);
            // 
            // _homeButton
            // 
            this._homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._homeButton.Location = new System.Drawing.Point(10, 96);
            this._homeButton.Name = "_homeButton";
            this._homeButton.Size = new System.Drawing.Size(111, 27);
            this._homeButton.TabIndex = 24;
            this._homeButton.Text = "На главную";
            this._homeButton.UseVisualStyleBackColor = true;
            this._homeButton.Click += new System.EventHandler(this._homeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Группа";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this._numberGroupTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._groupComboBox);
            this.panel1.Controls.Add(this._homeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._createGroupButton);
            this.panel1.Location = new System.Drawing.Point(20, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 130);
            this.panel1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Перевести в группу";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // _groupComboBox
            // 
            this._groupComboBox.FormattingEnabled = true;
            this._groupComboBox.Location = new System.Drawing.Point(307, 100);
            this._groupComboBox.Name = "_groupComboBox";
            this._groupComboBox.Size = new System.Drawing.Size(115, 21);
            this._groupComboBox.TabIndex = 28;
            // 
            // NumberGroup
            // 
            this.NumberGroup.HeaderText = "Группа";
            this.NumberGroup.Name = "NumberGroup";
            this.NumberGroup.ReadOnly = true;
            // 
            // AbouGroup
            // 
            this.AbouGroup.HeaderText = "Описание";
            this.AbouGroup.Name = "AbouGroup";
            this.AbouGroup.Width = 290;
            // 
            // _numberGroupTextBox
            // 
            this._numberGroupTextBox.Location = new System.Drawing.Point(10, 26);
            this._numberGroupTextBox.Name = "_numberGroupTextBox";
            this._numberGroupTextBox.Size = new System.Drawing.Size(100, 20);
            this._numberGroupTextBox.TabIndex = 30;
            this._numberGroupTextBox.TextChanged += new System.EventHandler(this._numberGroupTextBox_TextChanged);
            // 
            // ListOfStudentGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._nextButton);
            this.Controls.Add(this._removeButton);
            this.Controls.Add(this._reverseButton);
            this.Controls.Add(this.ListOfStudentGroupsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListOfStudentGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список групп";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfStudentGroupsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfStudentGroupsDataGridView;
        private System.Windows.Forms.Button _nextButton;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.Button _reverseButton;
        private System.Windows.Forms.Button _createGroupButton;
        private System.Windows.Forms.Button _homeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _groupComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbouGroup;
        private System.Windows.Forms.TextBox _numberGroupTextBox;
    }
}