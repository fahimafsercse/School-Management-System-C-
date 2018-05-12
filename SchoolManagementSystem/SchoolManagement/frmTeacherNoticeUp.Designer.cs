namespace SchoolManagement
{
    partial class frmTeacherNoticeUp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tNoticeSubtxt = new System.Windows.Forms.TextBox();
            this.bttnTeacherSend = new System.Windows.Forms.Button();
            this.txtTDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userChange = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClearAdminMsg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(383, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 296);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Subject";
            // 
            // tNoticeSubtxt
            // 
            this.tNoticeSubtxt.Location = new System.Drawing.Point(101, 105);
            this.tNoticeSubtxt.Name = "tNoticeSubtxt";
            this.tNoticeSubtxt.Size = new System.Drawing.Size(100, 20);
            this.tNoticeSubtxt.TabIndex = 20;
            // 
            // bttnTeacherSend
            // 
            this.bttnTeacherSend.Location = new System.Drawing.Point(94, 291);
            this.bttnTeacherSend.Name = "bttnTeacherSend";
            this.bttnTeacherSend.Size = new System.Drawing.Size(75, 23);
            this.bttnTeacherSend.TabIndex = 19;
            this.bttnTeacherSend.Text = "Send";
            this.bttnTeacherSend.UseVisualStyleBackColor = true;
            this.bttnTeacherSend.Click += new System.EventHandler(this.bttnTeacherSend_Click);
            // 
            // txtTDescription
            // 
            this.txtTDescription.Location = new System.Drawing.Point(94, 150);
            this.txtTDescription.Multiline = true;
            this.txtTDescription.Name = "txtTDescription";
            this.txtTDescription.Size = new System.Drawing.Size(241, 113);
            this.txtTDescription.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select User";
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(1020, -14);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(75, 45);
            this.userChange.TabIndex = 26;
            this.userChange.Text = "Change User";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(135, 370);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonClearAdminMsg
            // 
            this.buttonClearAdminMsg.Location = new System.Drawing.Point(188, 291);
            this.buttonClearAdminMsg.Name = "buttonClearAdminMsg";
            this.buttonClearAdminMsg.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAdminMsg.TabIndex = 24;
            this.buttonClearAdminMsg.Text = "Clear";
            this.buttonClearAdminMsg.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Updated Notice Board";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // frmTeacherNoticeUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 605);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tNoticeSubtxt);
            this.Controls.Add(this.bttnTeacherSend);
            this.Controls.Add(this.txtTDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClearAdminMsg);
            this.Controls.Add(this.label4);
            this.Name = "frmTeacherNoticeUp";
            this.Text = "frmTeacherNoticeUp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNoticeSubtxt;
        private System.Windows.Forms.Button bttnTeacherSend;
        private System.Windows.Forms.TextBox txtTDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userChange;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClearAdminMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}