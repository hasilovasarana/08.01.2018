namespace dataRelation
{
    partial class StartScreen
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
            this.book_isbn = new System.Windows.Forms.TextBox();
            this.publish_date = new System.Windows.Forms.DateTimePicker();
            this.publish_add_date = new System.Windows.Forms.DateTimePicker();
            this.book_price = new System.Windows.Forms.TextBox();
            this.book_amount = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.book_author = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.book_category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.book_lang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.book_format = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.book_publisher = new System.Windows.Forms.ComboBox();
            this.add_photo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booklangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookadddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookStoreDataDataSet1 = new dataRelation.bookStoreDataDataSet1();
            this.bookStoreDataDataSet = new dataRelation.bookStoreDataDataSet();
            this.bookStoreDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new dataRelation.bookStoreDataDataSet1TableAdapters.BooksTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.add_book = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // book_isbn
            // 
            this.book_isbn.Location = new System.Drawing.Point(141, 65);
            this.book_isbn.Name = "book_isbn";
            this.book_isbn.Size = new System.Drawing.Size(200, 20);
            this.book_isbn.TabIndex = 0;
            // 
            // publish_date
            // 
            this.publish_date.Location = new System.Drawing.Point(141, 143);
            this.publish_date.Name = "publish_date";
            this.publish_date.Size = new System.Drawing.Size(200, 20);
            this.publish_date.TabIndex = 1;
            // 
            // publish_add_date
            // 
            this.publish_add_date.Location = new System.Drawing.Point(141, 169);
            this.publish_add_date.Name = "publish_add_date";
            this.publish_add_date.Size = new System.Drawing.Size(200, 20);
            this.publish_add_date.TabIndex = 1;
            // 
            // book_price
            // 
            this.book_price.Location = new System.Drawing.Point(141, 91);
            this.book_price.Name = "book_price";
            this.book_price.Size = new System.Drawing.Size(200, 20);
            this.book_price.TabIndex = 0;
            // 
            // book_amount
            // 
            this.book_amount.Location = new System.Drawing.Point(141, 117);
            this.book_amount.Name = "book_amount";
            this.book_amount.Size = new System.Drawing.Size(200, 20);
            this.book_amount.TabIndex = 0;
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(141, 39);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(200, 20);
            this.book_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Book Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Publish Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Publish Add Date:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(521, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 101);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Author:";
            // 
            // book_author
            // 
            this.book_author.FormattingEnabled = true;
            this.book_author.Location = new System.Drawing.Point(771, 143);
            this.book_author.Name = "book_author";
            this.book_author.Size = new System.Drawing.Size(121, 21);
            this.book_author.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(702, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Categories:";
            // 
            // book_category
            // 
            this.book_category.FormattingEnabled = true;
            this.book_category.Location = new System.Drawing.Point(771, 173);
            this.book_category.Name = "book_category";
            this.book_category.Size = new System.Drawing.Size(121, 21);
            this.book_category.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(704, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Language:";
            // 
            // book_lang
            // 
            this.book_lang.FormattingEnabled = true;
            this.book_lang.Location = new System.Drawing.Point(771, 200);
            this.book_lang.Name = "book_lang";
            this.book_lang.Size = new System.Drawing.Size(121, 21);
            this.book_lang.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(720, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Format:";
            // 
            // book_format
            // 
            this.book_format.FormattingEnabled = true;
            this.book_format.Location = new System.Drawing.Point(771, 227);
            this.book_format.Name = "book_format";
            this.book_format.Size = new System.Drawing.Size(121, 21);
            this.book_format.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(709, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Publisher:";
            // 
            // book_publisher
            // 
            this.book_publisher.FormattingEnabled = true;
            this.book_publisher.Location = new System.Drawing.Point(771, 254);
            this.book_publisher.Name = "book_publisher";
            this.book_publisher.Size = new System.Drawing.Size(121, 21);
            this.book_publisher.TabIndex = 5;
            // 
            // add_photo
            // 
            this.add_photo.Location = new System.Drawing.Point(521, 148);
            this.add_photo.Name = "add_photo";
            this.add_photo.Size = new System.Drawing.Size(134, 123);
            this.add_photo.TabIndex = 6;
            this.add_photo.Text = "Add Photo";
            this.add_photo.UseVisualStyleBackColor = true;
            this.add_photo.Click += new System.EventHandler(this.add_photo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Book Info:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookisbnDataGridViewTextBoxColumn,
            this.bookcategoryDataGridViewTextBoxColumn,
            this.booklangDataGridViewTextBoxColumn,
            this.bookpriceDataGridViewTextBoxColumn,
            this.bookamountDataGridViewTextBoxColumn,
            this.bookinfoDataGridViewTextBoxColumn,
            this.bookpublishdateDataGridViewTextBoxColumn,
            this.bookadddateDataGridViewTextBoxColumn,
            this.bookpublisherDataGridViewTextBoxColumn,
            this.booktypeDataGridViewTextBoxColumn,
            this.bookphotoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "book_name";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // bookauthorDataGridViewTextBoxColumn
            // 
            this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.HeaderText = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
            // 
            // bookisbnDataGridViewTextBoxColumn
            // 
            this.bookisbnDataGridViewTextBoxColumn.DataPropertyName = "book_isbn";
            this.bookisbnDataGridViewTextBoxColumn.HeaderText = "book_isbn";
            this.bookisbnDataGridViewTextBoxColumn.Name = "bookisbnDataGridViewTextBoxColumn";
            // 
            // bookcategoryDataGridViewTextBoxColumn
            // 
            this.bookcategoryDataGridViewTextBoxColumn.DataPropertyName = "book_category";
            this.bookcategoryDataGridViewTextBoxColumn.HeaderText = "book_category";
            this.bookcategoryDataGridViewTextBoxColumn.Name = "bookcategoryDataGridViewTextBoxColumn";
            // 
            // booklangDataGridViewTextBoxColumn
            // 
            this.booklangDataGridViewTextBoxColumn.DataPropertyName = "book_lang";
            this.booklangDataGridViewTextBoxColumn.HeaderText = "book_lang";
            this.booklangDataGridViewTextBoxColumn.Name = "booklangDataGridViewTextBoxColumn";
            // 
            // bookpriceDataGridViewTextBoxColumn
            // 
            this.bookpriceDataGridViewTextBoxColumn.DataPropertyName = "book_price";
            this.bookpriceDataGridViewTextBoxColumn.HeaderText = "book_price";
            this.bookpriceDataGridViewTextBoxColumn.Name = "bookpriceDataGridViewTextBoxColumn";
            // 
            // bookamountDataGridViewTextBoxColumn
            // 
            this.bookamountDataGridViewTextBoxColumn.DataPropertyName = "book_amount";
            this.bookamountDataGridViewTextBoxColumn.HeaderText = "book_amount";
            this.bookamountDataGridViewTextBoxColumn.Name = "bookamountDataGridViewTextBoxColumn";
            // 
            // bookinfoDataGridViewTextBoxColumn
            // 
            this.bookinfoDataGridViewTextBoxColumn.DataPropertyName = "book_info";
            this.bookinfoDataGridViewTextBoxColumn.HeaderText = "book_info";
            this.bookinfoDataGridViewTextBoxColumn.Name = "bookinfoDataGridViewTextBoxColumn";
            // 
            // bookpublishdateDataGridViewTextBoxColumn
            // 
            this.bookpublishdateDataGridViewTextBoxColumn.DataPropertyName = "book_publish_date";
            this.bookpublishdateDataGridViewTextBoxColumn.HeaderText = "book_publish_date";
            this.bookpublishdateDataGridViewTextBoxColumn.Name = "bookpublishdateDataGridViewTextBoxColumn";
            // 
            // bookadddateDataGridViewTextBoxColumn
            // 
            this.bookadddateDataGridViewTextBoxColumn.DataPropertyName = "book_add_date";
            this.bookadddateDataGridViewTextBoxColumn.HeaderText = "book_add_date";
            this.bookadddateDataGridViewTextBoxColumn.Name = "bookadddateDataGridViewTextBoxColumn";
            // 
            // bookpublisherDataGridViewTextBoxColumn
            // 
            this.bookpublisherDataGridViewTextBoxColumn.DataPropertyName = "book_publisher";
            this.bookpublisherDataGridViewTextBoxColumn.HeaderText = "book_publisher";
            this.bookpublisherDataGridViewTextBoxColumn.Name = "bookpublisherDataGridViewTextBoxColumn";
            // 
            // booktypeDataGridViewTextBoxColumn
            // 
            this.booktypeDataGridViewTextBoxColumn.DataPropertyName = "book_type";
            this.booktypeDataGridViewTextBoxColumn.HeaderText = "book_type";
            this.booktypeDataGridViewTextBoxColumn.Name = "booktypeDataGridViewTextBoxColumn";
            // 
            // bookphotoDataGridViewTextBoxColumn
            // 
            this.bookphotoDataGridViewTextBoxColumn.DataPropertyName = "book_photo";
            this.bookphotoDataGridViewTextBoxColumn.HeaderText = "book_photo";
            this.bookphotoDataGridViewTextBoxColumn.Name = "bookphotoDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookStoreDataDataSet1;
            // 
            // bookStoreDataDataSet1
            // 
            this.bookStoreDataDataSet1.DataSetName = "bookStoreDataDataSet1";
            this.bookStoreDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookStoreDataDataSet
            // 
            this.bookStoreDataDataSet.DataSetName = "bookStoreDataDataSet";
            this.bookStoreDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookStoreDataDataSetBindingSource
            // 
            this.bookStoreDataDataSetBindingSource.DataSource = this.bookStoreDataDataSet;
            this.bookStoreDataDataSetBindingSource.Position = 0;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Book Photo:";
            // 
            // add_book
            // 
            this.add_book.Location = new System.Drawing.Point(266, 208);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(75, 23);
            this.add_book.TabIndex = 10;
            this.add_book.Text = "Insert";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click_1);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(141, 207);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 11;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 535);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.add_book);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.book_publisher);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.book_format);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.book_lang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.book_category);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.book_author);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publish_add_date);
            this.Controls.Add(this.publish_date);
            this.Controls.Add(this.book_amount);
            this.Controls.Add(this.book_price);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.book_isbn);
            this.Controls.Add(this.add_photo);
            this.Name = "StartScreen";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookStoreDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox book_isbn;
        private System.Windows.Forms.DateTimePicker publish_date;
        private System.Windows.Forms.DateTimePicker publish_add_date;
        private System.Windows.Forms.TextBox book_price;
        private System.Windows.Forms.TextBox book_amount;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox book_author;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox book_category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox book_lang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox book_format;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox book_publisher;
        private System.Windows.Forms.Button add_photo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookStoreDataDataSetBindingSource;
        private bookStoreDataDataSet bookStoreDataDataSet;
        private bookStoreDataDataSet1 bookStoreDataDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private bookStoreDataDataSet1TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookisbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booklangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookadddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookphotoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.Button savebutton;
    }
}