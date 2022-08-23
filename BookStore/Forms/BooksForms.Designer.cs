namespace BookStore.Forms
{
    partial class BooksForms
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labbooks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txttitlecr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtauthorCr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcategoryCr = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.firstbtn = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.lastbtn = new System.Windows.Forms.Button();
            this.txtcurrentpage = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(837, 272);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labbooks
            // 
            this.labbooks.AutoSize = true;
            this.labbooks.Location = new System.Drawing.Point(13, 53);
            this.labbooks.Name = "labbooks";
            this.labbooks.Size = new System.Drawing.Size(55, 15);
            this.labbooks.TabIndex = 2;
            this.labbooks.Text = "NbBooks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttitlecr
            // 
            this.txttitlecr.Location = new System.Drawing.Point(49, 21);
            this.txttitlecr.Name = "txttitlecr";
            this.txttitlecr.Size = new System.Drawing.Size(100, 23);
            this.txttitlecr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Author :";
            // 
            // txtauthorCr
            // 
            this.txtauthorCr.FormattingEnabled = true;
            this.txtauthorCr.Location = new System.Drawing.Point(414, 21);
            this.txtauthorCr.Name = "txtauthorCr";
            this.txtauthorCr.Size = new System.Drawing.Size(121, 23);
            this.txtauthorCr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filtre :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtcategoryCr);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtauthorCr);
            this.groupBox1.Controls.Add(this.txttitlecr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(212, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 64);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtcategoryCr
            // 
            this.txtcategoryCr.Location = new System.Drawing.Point(222, 21);
            this.txtcategoryCr.Name = "txtcategoryCr";
            this.txtcategoryCr.Size = new System.Drawing.Size(123, 23);
            this.txtcategoryCr.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // firstbtn
            // 
            this.firstbtn.Location = new System.Drawing.Point(545, 108);
            this.firstbtn.Name = "firstbtn";
            this.firstbtn.Size = new System.Drawing.Size(50, 23);
            this.firstbtn.TabIndex = 14;
            this.firstbtn.Text = "First";
            this.firstbtn.UseVisualStyleBackColor = true;
            this.firstbtn.Click += new System.EventHandler(this.firstbtn_Click_1);
            // 
            // previousbtn
            // 
            this.previousbtn.Location = new System.Drawing.Point(601, 108);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(68, 23);
            this.previousbtn.TabIndex = 15;
            this.previousbtn.Text = "Previous";
            this.previousbtn.UseVisualStyleBackColor = true;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(675, 108);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(50, 23);
            this.nextbtn.TabIndex = 16;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // lastbtn
            // 
            this.lastbtn.Location = new System.Drawing.Point(731, 108);
            this.lastbtn.Name = "lastbtn";
            this.lastbtn.Size = new System.Drawing.Size(50, 23);
            this.lastbtn.TabIndex = 17;
            this.lastbtn.Text = "Last";
            this.lastbtn.UseVisualStyleBackColor = true;
            this.lastbtn.Click += new System.EventHandler(this.lastbtn_Click);
            // 
            // txtcurrentpage
            // 
            this.txtcurrentpage.AutoSize = true;
            this.txtcurrentpage.Location = new System.Drawing.Point(787, 112);
            this.txtcurrentpage.Name = "txtcurrentpage";
            this.txtcurrentpage.Size = new System.Drawing.Size(16, 15);
            this.txtcurrentpage.TabIndex = 18;
            this.txtcurrentpage.Text = "...";
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(761, 9);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(89, 23);
            this.btnprint.TabIndex = 19;
            this.btnprint.Text = "Print PDF";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // BooksForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtcurrentpage);
            this.Controls.Add(this.lastbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.firstbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labbooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "BooksForms";
            this.Size = new System.Drawing.Size(864, 426);
            this.Load += new System.EventHandler(this.BooksForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labbooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttitlecr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtauthorCr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtcategoryCr;
        private System.Windows.Forms.Button firstbtn;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button lastbtn;
        private System.Windows.Forms.Label txtcurrentpage;
        private System.Windows.Forms.Button btnprint;
    }
}
