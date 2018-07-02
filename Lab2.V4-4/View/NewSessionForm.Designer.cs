namespace Lab4.View
{
    partial class NewSessionForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.winterRadioButton = new System.Windows.Forms.RadioButton();
            this.summerRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(188, 278);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(71, 34);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(85, 278);
            this.addButton.Margin = new System.Windows.Forms.Padding(1);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 34);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // winterRadioButton
            // 
            this.winterRadioButton.AutoSize = true;
            this.winterRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.winterRadioButton.Location = new System.Drawing.Point(135, 140);
            this.winterRadioButton.Name = "winterRadioButton";
            this.winterRadioButton.Size = new System.Drawing.Size(76, 21);
            this.winterRadioButton.TabIndex = 13;
            this.winterRadioButton.TabStop = true;
            this.winterRadioButton.Text = "Зимняя";
            this.winterRadioButton.UseVisualStyleBackColor = true;
            this.winterRadioButton.CheckedChanged += new System.EventHandler(this.SessionTypeCheckedChanged);
            // 
            // summerRadioButton
            // 
            this.summerRadioButton.AutoSize = true;
            this.summerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.summerRadioButton.Location = new System.Drawing.Point(136, 167);
            this.summerRadioButton.Name = "summerRadioButton";
            this.summerRadioButton.Size = new System.Drawing.Size(75, 21);
            this.summerRadioButton.TabIndex = 14;
            this.summerRadioButton.TabStop = true;
            this.summerRadioButton.Text = "Летняя";
            this.summerRadioButton.UseVisualStyleBackColor = true;
            this.summerRadioButton.CheckedChanged += new System.EventHandler(this.SessionTypeCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тип сессии";
            // 
            // NewSessionForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(350, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.summerRadioButton);
            this.Controls.Add(this.winterRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить сессию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton winterRadioButton;
        private System.Windows.Forms.RadioButton summerRadioButton;
        private System.Windows.Forms.Label label1;
    }
}