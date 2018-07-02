namespace Lab4.View
{
    partial class UnivercityForm
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
            this.openSessionFormButton = new System.Windows.Forms.Button();
            this.openGroupFormButton = new System.Windows.Forms.Button();
            this.openTeacherFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openSessionFormButton
            // 
            this.openSessionFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openSessionFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openSessionFormButton.Location = new System.Drawing.Point(314, 224);
            this.openSessionFormButton.Margin = new System.Windows.Forms.Padding(1);
            this.openSessionFormButton.Name = "openSessionFormButton";
            this.openSessionFormButton.Size = new System.Drawing.Size(171, 55);
            this.openSessionFormButton.TabIndex = 23;
            this.openSessionFormButton.Text = "Сессия";
            this.openSessionFormButton.UseVisualStyleBackColor = true;
            this.openSessionFormButton.Click += new System.EventHandler(this.openSessionFormButton_Click);
            // 
            // openGroupFormButton
            // 
            this.openGroupFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openGroupFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openGroupFormButton.Location = new System.Drawing.Point(314, 71);
            this.openGroupFormButton.Margin = new System.Windows.Forms.Padding(1);
            this.openGroupFormButton.Name = "openGroupFormButton";
            this.openGroupFormButton.Size = new System.Drawing.Size(171, 47);
            this.openGroupFormButton.TabIndex = 24;
            this.openGroupFormButton.Text = "Список групп";
            this.openGroupFormButton.UseVisualStyleBackColor = true;
            this.openGroupFormButton.Click += new System.EventHandler(this.openGroupFormButton_Click);
            // 
            // openTeacherFormButton
            // 
            this.openTeacherFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openTeacherFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.openTeacherFormButton.Location = new System.Drawing.Point(314, 146);
            this.openTeacherFormButton.Margin = new System.Windows.Forms.Padding(1);
            this.openTeacherFormButton.Name = "openTeacherFormButton";
            this.openTeacherFormButton.Size = new System.Drawing.Size(171, 58);
            this.openTeacherFormButton.TabIndex = 25;
            this.openTeacherFormButton.Text = "Список преподавателей";
            this.openTeacherFormButton.UseVisualStyleBackColor = true;
            this.openTeacherFormButton.Click += new System.EventHandler(this.openTeacherFormButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitButton.Location = new System.Drawing.Point(314, 293);
            this.exitButton.Margin = new System.Windows.Forms.Padding(1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 55);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UnivercityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openTeacherFormButton);
            this.Controls.Add(this.openGroupFormButton);
            this.Controls.Add(this.openSessionFormButton);
            this.Name = "UnivercityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnivercityFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSessionFormButton;
        private System.Windows.Forms.Button openGroupFormButton;
        private System.Windows.Forms.Button openTeacherFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}