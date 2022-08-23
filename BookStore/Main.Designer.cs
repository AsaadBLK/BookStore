namespace BookStore
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.Statisticbtn = new System.Windows.Forms.Button();
            this.Bookbtn = new System.Windows.Forms.Button();
            this.Authorbtn = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelcontenu = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.Statisticbtn);
            this.panelLeft.Controls.Add(this.Bookbtn);
            this.panelLeft.Controls.Add(this.Authorbtn);
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(106, 449);
            this.panelLeft.TabIndex = 0;
            // 
            // Statisticbtn
            // 
            this.Statisticbtn.Location = new System.Drawing.Point(9, 113);
            this.Statisticbtn.Name = "Statisticbtn";
            this.Statisticbtn.Size = new System.Drawing.Size(84, 23);
            this.Statisticbtn.TabIndex = 2;
            this.Statisticbtn.Text = "Statistics";
            this.Statisticbtn.UseVisualStyleBackColor = true;
            this.Statisticbtn.Click += new System.EventHandler(this.Statisticbtn_Click);
            // 
            // Bookbtn
            // 
            this.Bookbtn.Location = new System.Drawing.Point(9, 84);
            this.Bookbtn.Name = "Bookbtn";
            this.Bookbtn.Size = new System.Drawing.Size(84, 23);
            this.Bookbtn.TabIndex = 1;
            this.Bookbtn.Text = "Book";
            this.Bookbtn.UseVisualStyleBackColor = true;
            this.Bookbtn.Click += new System.EventHandler(this.Bookbtn_Click);
            // 
            // Authorbtn
            // 
            this.Authorbtn.Location = new System.Drawing.Point(9, 55);
            this.Authorbtn.Name = "Authorbtn";
            this.Authorbtn.Size = new System.Drawing.Size(84, 23);
            this.Authorbtn.TabIndex = 0;
            this.Authorbtn.Text = "Author";
            this.Authorbtn.UseVisualStyleBackColor = true;
            this.Authorbtn.Click += new System.EventHandler(this.Authorbtn_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTop.Location = new System.Drawing.Point(115, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(856, 37);
            this.panelTop.TabIndex = 1;
            // 
            // panelcontenu
            // 
            this.panelcontenu.Location = new System.Drawing.Point(115, 46);
            this.panelcontenu.Name = "panelcontenu";
            this.panelcontenu.Size = new System.Drawing.Size(856, 392);
            this.panelcontenu.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.panelcontenu);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Name = "Main";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelcontenu;
        private System.Windows.Forms.Button Statisticbtn;
        private System.Windows.Forms.Button Bookbtn;
        private System.Windows.Forms.Button Authorbtn;
    }
}
