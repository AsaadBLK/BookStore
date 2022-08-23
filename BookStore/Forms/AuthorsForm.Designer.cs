namespace BookStore.Forms
{
    partial class AuthorsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.AuthorbtnClick = new System.Windows.Forms.Button();
            this.Gf = new System.Windows.Forms.RadioButton();
            this.Gm = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nbauthors = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Authors";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatebtn);
            this.groupBox1.Controls.Add(this.AuthorbtnClick);
            this.groupBox1.Controls.Add(this.Gf);
            this.groupBox1.Controls.Add(this.Gm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(64, 199);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(84, 23);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // AuthorbtnClick
            // 
            this.AuthorbtnClick.Location = new System.Drawing.Point(64, 170);
            this.AuthorbtnClick.Name = "AuthorbtnClick";
            this.AuthorbtnClick.Size = new System.Drawing.Size(84, 23);
            this.AuthorbtnClick.TabIndex = 7;
            this.AuthorbtnClick.Text = "Save Author";
            this.AuthorbtnClick.UseVisualStyleBackColor = true;
            this.AuthorbtnClick.Click += new System.EventHandler(this.AuthorbtnClick_Click);
            // 
            // Gf
            // 
            this.Gf.AutoSize = true;
            this.Gf.Location = new System.Drawing.Point(121, 134);
            this.Gf.Name = "Gf";
            this.Gf.Size = new System.Drawing.Size(31, 19);
            this.Gf.TabIndex = 6;
            this.Gf.TabStop = true;
            this.Gf.Text = "F";
            this.Gf.UseVisualStyleBackColor = true;
            this.Gf.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Gm
            // 
            this.Gm.AutoSize = true;
            this.Gm.Location = new System.Drawing.Point(64, 134);
            this.Gm.Name = "Gm";
            this.Gm.Size = new System.Drawing.Size(36, 19);
            this.Gm.TabIndex = 5;
            this.Gm.TabStop = true;
            this.Gm.Text = "M";
            this.Gm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "List Authors";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(223, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(633, 373);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // nbauthors
            // 
            this.nbauthors.AutoSize = true;
            this.nbauthors.Location = new System.Drawing.Point(317, 13);
            this.nbauthors.Name = "nbauthors";
            this.nbauthors.Size = new System.Drawing.Size(17, 15);
            this.nbauthors.TabIndex = 4;
            this.nbauthors.Text = "__";
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nbauthors);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AuthorsForm";
            this.Size = new System.Drawing.Size(859, 439);
            this.Load += new System.EventHandler(this.AuthorsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Gf;
        private System.Windows.Forms.RadioButton Gm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AuthorbtnClick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nbauthors;
        private System.Windows.Forms.Button updatebtn;
    }
}
