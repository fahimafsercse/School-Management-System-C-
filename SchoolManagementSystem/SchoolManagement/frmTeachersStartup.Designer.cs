namespace SchoolManagement
{
    partial class frmTeachersStartup
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
            this.bttnAssignGrades = new System.Windows.Forms.Button();
            this.bttnTeacherProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noticeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAssignGrades
            // 
            this.bttnAssignGrades.Location = new System.Drawing.Point(167, 140);
            this.bttnAssignGrades.Name = "bttnAssignGrades";
            this.bttnAssignGrades.Size = new System.Drawing.Size(143, 23);
            this.bttnAssignGrades.TabIndex = 0;
            this.bttnAssignGrades.Text = "Assign Grades";
            this.bttnAssignGrades.UseVisualStyleBackColor = true;
            this.bttnAssignGrades.Click += new System.EventHandler(this.bttnAssignGrades_Click);
            // 
            // bttnTeacherProfile
            // 
            this.bttnTeacherProfile.Location = new System.Drawing.Point(167, 212);
            this.bttnTeacherProfile.Name = "bttnTeacherProfile";
            this.bttnTeacherProfile.Size = new System.Drawing.Size(143, 23);
            this.bttnTeacherProfile.TabIndex = 2;
            this.bttnTeacherProfile.Text = "Profile";
            this.bttnTeacherProfile.UseVisualStyleBackColor = true;
            this.bttnTeacherProfile.Click += new System.EventHandler(this.bttnTeacherProfile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Change User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 296);
            this.dataGridView1.TabIndex = 7;
            // 
            // noticeButton
            // 
            this.noticeButton.Location = new System.Drawing.Point(167, 293);
            this.noticeButton.Name = "noticeButton";
            this.noticeButton.Size = new System.Drawing.Size(143, 23);
            this.noticeButton.TabIndex = 8;
            this.noticeButton.Text = "Notice";
            this.noticeButton.UseVisualStyleBackColor = true;
            this.noticeButton.Click += new System.EventHandler(this.noticeButton_Click);
            // 
            // frmTeachersStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 475);
            this.Controls.Add(this.noticeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnTeacherProfile);
            this.Controls.Add(this.bttnAssignGrades);
            this.Name = "frmTeachersStartup";
            this.Text = "frmTeachersStartup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAssignGrades;
        private System.Windows.Forms.Button bttnTeacherProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button noticeButton;
    }
}