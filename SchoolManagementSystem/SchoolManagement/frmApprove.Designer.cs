namespace SchoolManagement
{
    partial class frmApprove
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bttnBackFromAprove = new System.Windows.Forms.Button();
            this.userChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(662, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.add,
            this.del});
            this.dataGridView1.Location = new System.Drawing.Point(21, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(871, 275);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewApprove_CellContentClick);
            // 
            // add
            // 
            this.add.HeaderText = "";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.add.Text = "ADD";
            this.add.UseColumnTextForButtonValue = true;
            // 
            // del
            // 
            this.del.HeaderText = "";
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.del.Text = "REMOVE";
            this.del.UseColumnTextForButtonValue = true;
            // 
            // bttnBackFromAprove
            // 
            this.bttnBackFromAprove.Location = new System.Drawing.Point(388, 385);
            this.bttnBackFromAprove.Name = "bttnBackFromAprove";
            this.bttnBackFromAprove.Size = new System.Drawing.Size(75, 23);
            this.bttnBackFromAprove.TabIndex = 3;
            this.bttnBackFromAprove.Text = "Back";
            this.bttnBackFromAprove.UseVisualStyleBackColor = true;
            this.bttnBackFromAprove.Click += new System.EventHandler(this.bttnBackFromAprove_Click);
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(817, 12);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(75, 45);
            this.userChange.TabIndex = 9;
            this.userChange.Text = "Change User";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pending Registration List";
            // 
            // frmApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.bttnBackFromAprove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmApprove";
            this.Text = "frmApprove";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnBackFromAprove;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.Button userChange;
        private System.Windows.Forms.Label label2;
    }
}