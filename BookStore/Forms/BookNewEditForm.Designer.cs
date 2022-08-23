namespace BookStore.Forms
{
    partial class BookNewEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImageCover = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.combcat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combauth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnbpages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookbtnClick = new System.Windows.Forms.Button();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Books";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtImageCover);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.combcat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.combauth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtnbpages);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bookbtnClick);
            this.groupBox1.Controls.Add(this.txtdesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttitre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Image Path";
            // 
            // txtImageCover
            // 
            this.txtImageCover.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImageCover.Location = new System.Drawing.Point(223, 37);
            this.txtImageCover.Name = "txtImageCover";
            this.txtImageCover.Size = new System.Drawing.Size(148, 114);
            this.txtImageCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtImageCover.TabIndex = 21;
            this.txtImageCover.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combcat
            // 
            this.combcat.FormattingEnabled = true;
            this.combcat.Location = new System.Drawing.Point(17, 265);
            this.combcat.Name = "combcat";
            this.combcat.Size = new System.Drawing.Size(170, 23);
            this.combcat.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Category :";
            // 
            // combauth
            // 
            this.combauth.FormattingEnabled = true;
            this.combauth.Location = new System.Drawing.Point(17, 219);
            this.combauth.Name = "combauth";
            this.combauth.Size = new System.Drawing.Size(170, 23);
            this.combauth.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Author :";
            // 
            // txtnbpages
            // 
            this.txtnbpages.Location = new System.Drawing.Point(96, 172);
            this.txtnbpages.Name = "txtnbpages";
            this.txtnbpages.Size = new System.Drawing.Size(73, 23);
            this.txtnbpages.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nb pages :";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(17, 172);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(73, 23);
            this.txtprice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Published Date : ";
            // 
            // bookbtnClick
            // 
            this.bookbtnClick.Location = new System.Drawing.Point(103, 294);
            this.bookbtnClick.Name = "bookbtnClick";
            this.bookbtnClick.Size = new System.Drawing.Size(84, 23);
            this.bookbtnClick.TabIndex = 7;
            this.bookbtnClick.Text = "Add book";
            this.bookbtnClick.UseVisualStyleBackColor = true;
            this.bookbtnClick.Click += new System.EventHandler(this.bookbtnClick_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(17, 81);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(170, 23);
            this.txtdesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description :";
            // 
            // txttitre
            // 
            this.txttitre.Location = new System.Drawing.Point(17, 37);
            this.txttitre.Name = "txttitre";
            this.txttitre.Size = new System.Drawing.Size(170, 23);
            this.txttitre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titre :";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // BookNewEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BookNewEditForm";
            this.Text = "BookNewEditForm";
            this.Load += new System.EventHandler(this.BookNewEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combcat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combauth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnbpages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bookbtnClick;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox txtImageCover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}