namespace SchoolManagement
{
    partial class frmStudentStartup
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
            this.bttnProfile = new System.Windows.Forms.Button();
            this.bttnGrades = new System.Windows.Forms.Button();
            this.bttnCourseTechInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.userChange = new System.Windows.Forms.Button();
            this.buttonGetBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnProfile
            // 
            this.bttnProfile.Location = new System.Drawing.Point(93, 76);
            this.bttnProfile.Name = "bttnProfile";
            this.bttnProfile.Size = new System.Drawing.Size(75, 23);
            this.bttnProfile.TabIndex = 0;
            this.bttnProfile.Text = "Profile";
            this.bttnProfile.UseVisualStyleBackColor = true;
            this.bttnProfile.Click += new System.EventHandler(this.bttnProfile_Click);
            // 
            // bttnGrades
            // 
            this.bttnGrades.Location = new System.Drawing.Point(93, 162);
            this.bttnGrades.Name = "bttnGrades";
            this.bttnGrades.Size = new System.Drawing.Size(75, 23);
            this.bttnGrades.TabIndex = 2;
            this.bttnGrades.Text = "View Grades";
            this.bttnGrades.UseVisualStyleBackColor = true;
            this.bttnGrades.Click += new System.EventHandler(this.bttnGrades_Click);
            // 
            // bttnCourseTechInfo
            // 
            this.bttnCourseTechInfo.Location = new System.Drawing.Point(69, 240);
            this.bttnCourseTechInfo.Name = "bttnCourseTechInfo";
            this.bttnCourseTechInfo.Size = new System.Drawing.Size(123, 23);
            this.bttnCourseTechInfo.TabIndex = 4;
            this.bttnCourseTechInfo.Text = "Course Teacher Info";
            this.bttnCourseTechInfo.UseVisualStyleBackColor = true;
            this.bttnCourseTechInfo.Click += new System.EventHandler(this.bttnCourseTechInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 366);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Notice Board";
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(958, 12);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(75, 45);
            this.userChange.TabIndex = 9;
            this.userChange.Text = "Change User";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // buttonGetBook
            // 
            this.buttonGetBook.Location = new System.Drawing.Point(93, 329);
            this.buttonGetBook.Name = "buttonGetBook";
            this.buttonGetBook.Size = new System.Drawing.Size(75, 23);
            this.buttonGetBook.TabIndex = 10;
            this.buttonGetBook.Text = "Get Books";
            this.buttonGetBook.UseVisualStyleBackColor = true;
            this.buttonGetBook.Click += new System.EventHandler(this.buttonGetBook_Click);
            // 
            // frmStudentStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 523);
            this.Controls.Add(this.buttonGetBook);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnCourseTechInfo);
            this.Controls.Add(this.bttnGrades);
            this.Controls.Add(this.bttnProfile);
            this.Name = "frmStudentStartup";
            this.Text = "frmStudentStartup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnProfile;
        private System.Windows.Forms.Button bttnGrades;
        private System.Windows.Forms.Button bttnCourseTechInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userChange;
        private System.Windows.Forms.Button buttonGetBook;
    }
}