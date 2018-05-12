namespace SchoolManagement
{
    partial class frmAdminStartup
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
            this.bttnAdminProfile = new System.Windows.Forms.Button();
            this.bttnApprove = new System.Windows.Forms.Button();
            this.bttnAdminBookUP = new System.Windows.Forms.Button();
            this.bttnAdminNotice = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnAdminProfile
            // 
            this.bttnAdminProfile.Location = new System.Drawing.Point(83, 45);
            this.bttnAdminProfile.Name = "bttnAdminProfile";
            this.bttnAdminProfile.Size = new System.Drawing.Size(75, 23);
            this.bttnAdminProfile.TabIndex = 0;
            this.bttnAdminProfile.Text = "Profile";
            this.bttnAdminProfile.UseVisualStyleBackColor = true;
            // 
            // bttnApprove
            // 
            this.bttnApprove.Location = new System.Drawing.Point(83, 122);
            this.bttnApprove.Name = "bttnApprove";
            this.bttnApprove.Size = new System.Drawing.Size(75, 34);
            this.bttnApprove.TabIndex = 1;
            this.bttnApprove.Text = "Approve";
            this.bttnApprove.UseVisualStyleBackColor = true;
            this.bttnApprove.Click += new System.EventHandler(this.bttnApprove_Click);
            // 
            // bttnAdminBookUP
            // 
            this.bttnAdminBookUP.Location = new System.Drawing.Point(83, 340);
            this.bttnAdminBookUP.Name = "bttnAdminBookUP";
            this.bttnAdminBookUP.Size = new System.Drawing.Size(75, 34);
            this.bttnAdminBookUP.TabIndex = 4;
            this.bttnAdminBookUP.Text = "Upload Book";
            this.bttnAdminBookUP.UseVisualStyleBackColor = true;
            this.bttnAdminBookUP.Click += new System.EventHandler(this.bttnAdminBookUP_Click);
            // 
            // bttnAdminNotice
            // 
            this.bttnAdminNotice.Location = new System.Drawing.Point(83, 244);
            this.bttnAdminNotice.Name = "bttnAdminNotice";
            this.bttnAdminNotice.Size = new System.Drawing.Size(75, 34);
            this.bttnAdminNotice.TabIndex = 3;
            this.bttnAdminNotice.Text = "Up Notice";
            this.bttnAdminNotice.UseVisualStyleBackColor = true;
            this.bttnAdminNotice.Click += new System.EventHandler(this.bttnAdminNotice_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(768, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(705, 289);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(871, 12);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(75, 45);
            this.userChange.TabIndex = 8;
            this.userChange.Text = "Change User";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Registered Teachers/Student\'s";
            // 
            // frmAdminStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttnAdminBookUP);
            this.Controls.Add(this.bttnAdminNotice);
            this.Controls.Add(this.bttnApprove);
            this.Controls.Add(this.bttnAdminProfile);
            this.Name = "frmAdminStartup";
            this.Text = "frmAdminStartup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAdminProfile;
        private System.Windows.Forms.Button bttnApprove;
        private System.Windows.Forms.Button bttnAdminBookUP;
        private System.Windows.Forms.Button bttnAdminNotice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button userChange;
        private System.Windows.Forms.Label label2;
    }
}