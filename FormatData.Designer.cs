namespace dataRelation
{
    partial class FormatData
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
            this.bookStoreDataDataSet5 = new dataRelation.bookStoreDataDataSet5();
            this.bookTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTypesTableAdapter = new dataRelation.bookStoreDataDataSet5TableAdapters.BookTypesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.booktypenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookStoreDataDataSet5
            // 
            this.bookStoreDataDataSet5.DataSetName = "bookStoreDataDataSet5";
            this.bookStoreDataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTypesBindingSource
            // 
            this.bookTypesBindingSource.DataMember = "BookTypes";
            this.bookTypesBindingSource.DataSource = this.bookStoreDataDataSet5;
            // 
            // bookTypesTableAdapter
            // 
            this.bookTypesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booktypenameDataGridViewTextBoxColumn
            // 
            this.booktypenameDataGridViewTextBoxColumn.DataPropertyName = "book_type_name";
            this.booktypenameDataGridViewTextBoxColumn.HeaderText = "book_type_name";
            this.booktypenameDataGridViewTextBoxColumn.Name = "booktypenameDataGridViewTextBoxColumn";
            // 
            // FormatData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 320);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormatData";
            this.Text = "FormatData";
            this.Load += new System.EventHandler(this.FormatData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bookStoreDataDataSet5 bookStoreDataDataSet5;
        private System.Windows.Forms.BindingSource bookTypesBindingSource;
        private bookStoreDataDataSet5TableAdapters.BookTypesTableAdapter bookTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktypenameDataGridViewTextBoxColumn;
    }
}