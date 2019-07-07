namespace Tinybib_CS_edition
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
            this.articleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.authorSurname = new System.Windows.Forms.TextBox();
            this.websiteTitle = new System.Windows.Forms.TextBox();
            this.publisherName = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.datePublished = new System.Windows.Forms.TextBox();
            this.dateAccessed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cityPublished = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sectionTitle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.volumeNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // articleName
            // 
            this.articleName.Location = new System.Drawing.Point(204, 77);
            this.articleName.Name = "articleName";
            this.articleName.Size = new System.Drawing.Size(182, 22);
            this.articleName.TabIndex = 0;
            this.articleName.TextChanged += new System.EventHandler(this.articleName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(278, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tinybib 2.19";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // authorName
            // 
            this.authorName.Location = new System.Drawing.Point(204, 121);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(182, 22);
            this.authorName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author name:";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(539, 290);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(198, 23);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "Start!";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(592, 199);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 21);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Website";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(592, 227);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Book";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(592, 255);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 21);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ebook";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Author surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Website title:(if applicable)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Publisher/sponsor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "URL: (if applicable)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date published";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date accessed";
            // 
            // authorSurname
            // 
            this.authorSurname.Location = new System.Drawing.Point(204, 162);
            this.authorSurname.Name = "authorSurname";
            this.authorSurname.Size = new System.Drawing.Size(182, 22);
            this.authorSurname.TabIndex = 15;
            // 
            // websiteTitle
            // 
            this.websiteTitle.Location = new System.Drawing.Point(204, 199);
            this.websiteTitle.Name = "websiteTitle";
            this.websiteTitle.Size = new System.Drawing.Size(182, 22);
            this.websiteTitle.TabIndex = 16;
            // 
            // publisherName
            // 
            this.publisherName.Location = new System.Drawing.Point(204, 237);
            this.publisherName.Name = "publisherName";
            this.publisherName.Size = new System.Drawing.Size(182, 22);
            this.publisherName.TabIndex = 17;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(204, 276);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(182, 22);
            this.url.TabIndex = 18;
            // 
            // datePublished
            // 
            this.datePublished.Location = new System.Drawing.Point(204, 316);
            this.datePublished.Name = "datePublished";
            this.datePublished.Size = new System.Drawing.Size(182, 22);
            this.datePublished.TabIndex = 19;
            // 
            // dateAccessed
            // 
            this.dateAccessed.Location = new System.Drawing.Point(204, 353);
            this.dateAccessed.Name = "dateAccessed";
            this.dateAccessed.Size = new System.Drawing.Size(182, 22);
            this.dateAccessed.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "City published";
            // 
            // cityPublished
            // 
            this.cityPublished.Location = new System.Drawing.Point(204, 383);
            this.cityPublished.Name = "cityPublished";
            this.cityPublished.Size = new System.Drawing.Size(182, 22);
            this.cityPublished.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Title of the section used:";
            // 
            // sectionTitle
            // 
            this.sectionTitle.Location = new System.Drawing.Point(204, 425);
            this.sectionTitle.Name = "sectionTitle";
            this.sectionTitle.Size = new System.Drawing.Size(182, 22);
            this.sectionTitle.TabIndex = 24;
            this.sectionTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Volume number(if applicable):";
            // 
            // volumeNumber
            // 
            this.volumeNumber.Location = new System.Drawing.Point(204, 461);
            this.volumeNumber.Name = "volumeNumber";
            this.volumeNumber.Size = new System.Drawing.Size(182, 22);
            this.volumeNumber.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 506);
            this.Controls.Add(this.volumeNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sectionTitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cityPublished);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateAccessed);
            this.Controls.Add(this.datePublished);
            this.Controls.Add(this.url);
            this.Controls.Add(this.publisherName);
            this.Controls.Add(this.websiteTitle);
            this.Controls.Add(this.authorSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleName);
            this.Name = "Form1";
            this.Text = "Tinybib 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox articleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox authorSurname;
        private System.Windows.Forms.TextBox websiteTitle;
        private System.Windows.Forms.TextBox publisherName;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox datePublished;
        private System.Windows.Forms.TextBox dateAccessed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cityPublished;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sectionTitle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox volumeNumber;
    }
}

