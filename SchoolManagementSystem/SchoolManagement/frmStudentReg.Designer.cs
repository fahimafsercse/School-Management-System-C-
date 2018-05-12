namespace SchoolManagement
{
    partial class frmStudentReg
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
            this.i = new System.Windows.Forms.TextBox();
            this.co = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelStudentMail = new System.Windows.Forms.Label();
            this.labelStudentClass = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.SubmitStudentReg = new System.Windows.Forms.Button();
            this.studentRegBackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRegSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // i
            // 
            this.i.Location = new System.Drawing.Point(482, 115);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(100, 20);
            this.i.TabIndex = 22;
            // 
            // co
            // 
            this.co.Location = new System.Drawing.Point(482, 280);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(100, 20);
            this.co.TabIndex = 21;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(482, 227);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 20);
            this.m.TabIndex = 20;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(482, 166);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 19;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(482, 70);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contact No";
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(263, 122);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(18, 13);
            this.labelStudentId.TabIndex = 16;
            this.labelStudentId.Text = "ID";
            // 
            // labelStudentMail
            // 
            this.labelStudentMail.AutoSize = true;
            this.labelStudentMail.Location = new System.Drawing.Point(257, 230);
            this.labelStudentMail.Name = "labelStudentMail";
            this.labelStudentMail.Size = new System.Drawing.Size(67, 13);
            this.labelStudentMail.TabIndex = 15;
            this.labelStudentMail.Text = "Mail Address";
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.AutoSize = true;
            this.labelStudentClass.Location = new System.Drawing.Point(262, 173);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(32, 13);
            this.labelStudentClass.TabIndex = 14;
            this.labelStudentClass.Text = "Class";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(263, 70);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(35, 13);
            this.labelStudentName.TabIndex = 13;
            this.labelStudentName.Text = "Name";
            // 
            // SubmitStudentReg
            // 
            this.SubmitStudentReg.Location = new System.Drawing.Point(400, 327);
            this.SubmitStudentReg.Name = "SubmitStudentReg";
            this.SubmitStudentReg.Size = new System.Drawing.Size(75, 23);
            this.SubmitStudentReg.TabIndex = 23;
            this.SubmitStudentReg.Text = "Submit";
            this.SubmitStudentReg.UseVisualStyleBackColor = true;
            this.SubmitStudentReg.Click += new System.EventHandler(this.SubmitStudentReg_Click);
            // 
            // studentRegBackButton
            // 
            this.studentRegBackButton.Location = new System.Drawing.Point(400, 356);
            this.studentRegBackButton.Name = "studentRegBackButton";
            this.studentRegBackButton.Size = new System.Drawing.Size(75, 23);
            this.studentRegBackButton.TabIndex = 24;
            this.studentRegBackButton.Text = "BACK";
            this.studentRegBackButton.UseVisualStyleBackColor = true;
            this.studentRegBackButton.Click += new System.EventHandler(this.studentRegBackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Registration For";
            // 
            // comboBoxRegSelect
            // 
            this.comboBoxRegSelect.FormattingEnabled = true;
            this.comboBoxRegSelect.Location = new System.Drawing.Point(482, 22);
            this.comboBoxRegSelect.Name = "comboBoxRegSelect";
            this.comboBoxRegSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegSelect.TabIndex = 26;
            this.comboBoxRegSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegSelect_SelectedIndexChanged);
            // 
            // frmStudentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 430);
            this.Controls.Add(this.comboBoxRegSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentRegBackButton);
            this.Controls.Add(this.SubmitStudentReg);
            this.Controls.Add(this.i);
            this.Controls.Add(this.co);
            this.Controls.Add(this.m);
            this.Controls.Add(this.c);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.labelStudentMail);
            this.Controls.Add(this.labelStudentClass);
            this.Controls.Add(this.labelStudentName);
            this.Name = "frmStudentReg";
            this.Text = "frmStudentReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox i;
        private System.Windows.Forms.TextBox co;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelStudentMail;
        private System.Windows.Forms.Label labelStudentClass;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Button SubmitStudentReg;
        private System.Windows.Forms.Button studentRegBackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRegSelect;
    }
}