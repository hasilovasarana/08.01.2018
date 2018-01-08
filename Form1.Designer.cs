namespace dataRelation
{
    partial class Form1
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
            this.Open = new System.Windows.Forms.Button();
            this.openAuthor = new System.Windows.Forms.Button();
            this.openPublisher = new System.Windows.Forms.Button();
            this.openCategory = new System.Windows.Forms.Button();
            this.openFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(196, 67);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open form";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click_1);
            // 
            // openAuthor
            // 
            this.openAuthor.Location = new System.Drawing.Point(196, 117);
            this.openAuthor.Name = "openAuthor";
            this.openAuthor.Size = new System.Drawing.Size(75, 24);
            this.openAuthor.TabIndex = 1;
            this.openAuthor.Text = "Author";
            this.openAuthor.UseVisualStyleBackColor = true;
            this.openAuthor.Click += new System.EventHandler(this.openAuthor_Click);
            // 
            // openPublisher
            // 
            this.openPublisher.Location = new System.Drawing.Point(196, 253);
            this.openPublisher.Name = "openPublisher";
            this.openPublisher.Size = new System.Drawing.Size(75, 23);
            this.openPublisher.TabIndex = 2;
            this.openPublisher.Text = "Publisher";
            this.openPublisher.UseVisualStyleBackColor = true;
            this.openPublisher.Click += new System.EventHandler(this.openPublisher_Click);
            // 
            // openCategory
            // 
            this.openCategory.Location = new System.Drawing.Point(196, 164);
            this.openCategory.Name = "openCategory";
            this.openCategory.Size = new System.Drawing.Size(75, 23);
            this.openCategory.TabIndex = 3;
            this.openCategory.Text = "Category";
            this.openCategory.UseVisualStyleBackColor = true;
            this.openCategory.Click += new System.EventHandler(this.openCategory_Click);
            // 
            // openFormat
            // 
            this.openFormat.Location = new System.Drawing.Point(196, 210);
            this.openFormat.Name = "openFormat";
            this.openFormat.Size = new System.Drawing.Size(75, 23);
            this.openFormat.TabIndex = 2;
            this.openFormat.Text = "Format";
            this.openFormat.UseVisualStyleBackColor = true;
            this.openFormat.Click += new System.EventHandler(this.openFormat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 392);
            this.Controls.Add(this.openCategory);
            this.Controls.Add(this.openFormat);
            this.Controls.Add(this.openPublisher);
            this.Controls.Add(this.openAuthor);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.Text = "BookStore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button openAuthor;
        private System.Windows.Forms.Button openPublisher;
        private System.Windows.Forms.Button openCategory;
        private System.Windows.Forms.Button openFormat;
    }
}

