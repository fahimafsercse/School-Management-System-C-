namespace SchoolManagement
{
    partial class frmGrades
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttnBackfromGrades = new System.Windows.Forms.Button();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxBangla = new System.Windows.Forms.TextBox();
            this.labelMath = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelBangla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student\'s Grade";
            // 
            // bttnBackfromGrades
            // 
            this.bttnBackfromGrades.Location = new System.Drawing.Point(337, 310);
            this.bttnBackfromGrades.Name = "bttnBackfromGrades";
            this.bttnBackfromGrades.Size = new System.Drawing.Size(75, 23);
            this.bttnBackfromGrades.TabIndex = 8;
            this.bttnBackfromGrades.Text = "Back";
            this.bttnBackfromGrades.UseVisualStyleBackColor = true;
            this.bttnBackfromGrades.Click += new System.EventHandler(this.bttnBackfromGrades_Click);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(405, 273);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(100, 20);
            this.textBoxMath.TabIndex = 6;
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(405, 197);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnglish.TabIndex = 5;
            // 
            // textBoxBangla
            // 
            this.textBoxBangla.Location = new System.Drawing.Point(405, 145);
            this.textBoxBangla.Name = "textBoxBangla";
            this.textBoxBangla.Size = new System.Drawing.Size(100, 20);
            this.textBoxBangla.TabIndex = 4;
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Location = new System.Drawing.Point(266, 276);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(31, 13);
            this.labelMath.TabIndex = 2;
            this.labelMath.Text = "Math";
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(266, 200);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(41, 13);
            this.labelEnglish.TabIndex = 1;
            this.labelEnglish.Text = "English";
            // 
            // labelBangla
            // 
            this.labelBangla.AutoSize = true;
            this.labelBangla.Location = new System.Drawing.Point(267, 145);
            this.labelBangla.Name = "labelBangla";
            this.labelBangla.Size = new System.Drawing.Size(40, 13);
            this.labelBangla.TabIndex = 0;
            this.labelBangla.Text = "Bangla";
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnBackfromGrades);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.textBoxBangla);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelBangla);
            this.Name = "frmGrades";
            this.Text = "frmGrades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnBackfromGrades;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxBangla;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelBangla;
    }
}