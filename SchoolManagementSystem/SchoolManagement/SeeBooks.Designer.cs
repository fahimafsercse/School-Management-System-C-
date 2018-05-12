namespace SchoolManagement
{
    partial class SeeBooks
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.smsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smsDBDataSet = new SchoolManagement.smsDBDataSet();
            this.smsDBDataSet1 = new SchoolManagement.smsDBDataSet1();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter = new SchoolManagement.smsDBDataSet1TableAdapters.LibraryTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn,
            this.writerDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.libraryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(174, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // smsDBDataSetBindingSource
            // 
            this.smsDBDataSetBindingSource.DataSource = this.smsDBDataSet;
            this.smsDBDataSetBindingSource.Position = 0;
            // 
            // smsDBDataSet
            // 
            this.smsDBDataSet.DataSetName = "smsDBDataSet";
            this.smsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smsDBDataSet1
            // 
            this.smsDBDataSet1.DataSetName = "smsDBDataSet1";
            this.smsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Library";
            this.libraryBindingSource.DataSource = this.smsDBDataSet1;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            // 
            // writerDataGridViewTextBoxColumn
            // 
            this.writerDataGridViewTextBoxColumn.DataPropertyName = "Writer";
            this.writerDataGridViewTextBoxColumn.HeaderText = "Writer";
            this.writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // userChange
            // 
            this.userChange.Location = new System.Drawing.Point(782, 12);
            this.userChange.Name = "userChange";
            this.userChange.Size = new System.Drawing.Size(75, 45);
            this.userChange.TabIndex = 10;
            this.userChange.Text = "Change User";
            this.userChange.UseVisualStyleBackColor = true;
            this.userChange.Click += new System.EventHandler(this.userChange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeeBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userChange);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeeBooks";
            this.Text = "SeeBooks";
            this.Load += new System.EventHandler(this.SeeBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource smsDBDataSetBindingSource;
        private smsDBDataSet smsDBDataSet;
        private smsDBDataSet1 smsDBDataSet1;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private smsDBDataSet1TableAdapters.LibraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button userChange;
        private System.Windows.Forms.Button button1;
    }
}