namespace SchoolManagement
{
    partial class frmAdminUpNotice
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAdminSend = new System.Windows.Forms.Button();
            this.txtAdminDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminNoticeSubtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClearAdminMsg = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.userChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User";
            // 
            // bttnAdminSend
            // 
            this.bttnAdminSend.Location = new System.Drawing.Point(145, 314);
            this.bttnAdminSend.Name = "bttnAdminSend";
            this.bttnAdminSend.Size = new System.Drawing.Size(75, 23);
            this.bttnAdminSend.TabIndex = 7;
            this.bttnAdminSend.Text = "Send";
            this.bttnAdminSend.UseVisualStyleBackColor = true;
            this.bttnAdminSend.Click += new System.EventHandler(this.bttnAdminSend_Click);
            // 
            // txtAdminDescription
            // 
            this.txtAdminDescription.Location = new System.Drawing.Point(145, 173);
            this.txtAdminDescription.Multiline = true;
            this.txtAdminDescription.Name = "txtAdminDescription";
            this.txtAdminDescription.Size = new System.Drawing.Size(241, 113);
            this.txtAdminDescription.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type Message";
            // 
            // adminNoticeSubtxt
            // 
            this.adminNoticeSubtxt.Location = new System.Drawing.Point(152, 128);
            this.adminNoticeSubtxt.Name = "adminNoticeSubtxt";
            this.adminNoticeSubtxt.Size = new System.Drawing.Size(100, 20);
            this.adminNoticeSubtxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subject";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(419, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 296);
            this.dataGridView1.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Updated Notice Board";
            // 
            // buttonClearAdminMsg
            // 
            this.buttonClearAdminMsg.Location = new System.Drawing.Point(239, 314);
            this.buttonClearAdminMsg.Name = "buttonClearAdminMsg";
            this.buttonClearAdminMsg.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAdminMsg.TabIndex = 12;
            this.buttonClearAdminMsg.Text = "Clear";
            this.buttonClearAdminMsg.UseVisualStyleBackColor = true;
            this.buttonClearAdminMsg.Click += new System.EventHandler(this.buttonClearAdminMsg_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(186, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(1071, 9);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(75, 45);
            this.userChange.TabIndex = 14;
            this.userChange.Text = "Change User";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // frmAdminSendMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 453);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClearAdminMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminNoticeSubtxt);
            this.Controls.Add(this.bttnAdminSend);
            this.Controls.Add(this.txtAdminDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmAdminSendMsg";
            this.Text = "frmAdminSendMsg";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAdminSend;
        private System.Windows.Forms.TextBox txtAdminDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminNoticeSubtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClearAdminMsg;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button userChange;
    }
}