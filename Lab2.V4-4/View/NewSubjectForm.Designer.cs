namespace Lab4.View
{
    partial class NewSubjectForm
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
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.examRadioButton = new System.Windows.Forms.RadioButton();
            this.creditedRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.subjectNameTextBox.Location = new System.Drawing.Point(83, 103);
            this.subjectNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.subjectNameTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(80, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Предмет";
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(186, 292);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(71, 34);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(83, 292);
            this.addButton.Margin = new System.Windows.Forms.Padding(1);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 34);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(80, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Тип предмета";
            // 
            // examRadioButton
            // 
            this.examRadioButton.AutoSize = true;
            this.examRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.examRadioButton.Location = new System.Drawing.Point(134, 214);
            this.examRadioButton.Name = "examRadioButton";
            this.examRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.examRadioButton.Size = new System.Drawing.Size(82, 21);
            this.examRadioButton.TabIndex = 26;
            this.examRadioButton.TabStop = true;
            this.examRadioButton.Text = "Экзамен";
            this.examRadioButton.UseVisualStyleBackColor = true;
            this.examRadioButton.CheckedChanged += new System.EventHandler(this.SessionTypeCheckedChanged);
            // 
            // creditedRadioButton
            // 
            this.creditedRadioButton.AutoSize = true;
            this.creditedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.creditedRadioButton.Location = new System.Drawing.Point(133, 187);
            this.creditedRadioButton.Name = "creditedRadioButton";
            this.creditedRadioButton.Size = new System.Drawing.Size(66, 21);
            this.creditedRadioButton.TabIndex = 25;
            this.creditedRadioButton.TabStop = true;
            this.creditedRadioButton.Text = "Зачет";
            this.creditedRadioButton.UseVisualStyleBackColor = true;
            this.creditedRadioButton.CheckedChanged += new System.EventHandler(this.SessionTypeCheckedChanged);
            // 
            // NewSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.examRadioButton);
            this.Controls.Add(this.creditedRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subjectNameTextBox);
            this.Controls.Add(this.label2);
            this.Name = "NewSubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton examRadioButton;
        private System.Windows.Forms.RadioButton creditedRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}