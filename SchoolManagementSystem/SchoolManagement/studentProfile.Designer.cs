namespace SchoolManagement
{
    partial class studentProfile
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
            this.dataGridViewProfile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfile
            // 
            this.dataGridViewProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfile.Location = new System.Drawing.Point(106, 160);
            this.dataGridViewProfile.Name = "dataGridViewProfile";
            this.dataGridViewProfile.Size = new System.Drawing.Size(656, 117);
            this.dataGridViewProfile.TabIndex = 0;
            // 
            // studentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 472);
            this.Controls.Add(this.dataGridViewProfile);
            this.Name = "studentProfile";
            this.Text = "studentProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSTid;
        private System.Windows.Forms.DataGridView dataGridViewProfile;
    }
}