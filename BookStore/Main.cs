﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore.Forms;

namespace BookStore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Authorbtn_Click(object sender, EventArgs e)
        {
            AuthorsForm frmAuthor = new AuthorsForm();
            frmAuthor.Dock=DockStyle.Fill;
            panelcontenu.Controls.Clear();
            panelcontenu.Controls.Add(frmAuthor);

        }
    }
}