﻿namespace BookStore
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelcontenu = new System.Windows.Forms.Panel();
            this.Authorbtn = new System.Windows.Forms.Button();
            this.Bookbtn = new System.Windows.Forms.Button();
            this.Categorybtn = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.Categorybtn);
            this.panelLeft.Controls.Add(this.Bookbtn);
            this.panelLeft.Controls.Add(this.Authorbtn);
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(106, 449);
            this.panelLeft.TabIndex = 0;
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
            // Authorbtn
            // 
            this.Authorbtn.Location = new System.Drawing.Point(9, 55);
            this.Authorbtn.Name = "Authorbtn";
            this.Authorbtn.Size = new System.Drawing.Size(84, 23);
            this.Authorbtn.TabIndex = 0;
            this.Authorbtn.Text = "Author";
            this.Authorbtn.UseVisualStyleBackColor = true;
            // 
            // Bookbtn
            // 
            this.Bookbtn.Location = new System.Drawing.Point(9, 84);
            this.Bookbtn.Name = "Bookbtn";
            this.Bookbtn.Size = new System.Drawing.Size(84, 23);
            this.Bookbtn.TabIndex = 1;
            this.Bookbtn.Text = "Book";
            this.Bookbtn.UseVisualStyleBackColor = true;
            // 
            // Categorybtn
            // 
            this.Categorybtn.Location = new System.Drawing.Point(9, 113);
            this.Categorybtn.Name = "Categorybtn";
            this.Categorybtn.Size = new System.Drawing.Size(84, 23);
            this.Categorybtn.TabIndex = 2;
            this.Categorybtn.Text = "Category";
            this.Categorybtn.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button Categorybtn;
        private System.Windows.Forms.Button Bookbtn;
        private System.Windows.Forms.Button Authorbtn;
    }
}
