using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static BookStore.SharedData;

namespace BookStore.Forms
{
    public partial class StatisticsForm : UserControl
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                dataGridView1.DataSource = uow.Books.BookByAuthor();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Columns[0].Width = 350;
                dataGridView1.Columns[1].Width = 150;



                dataGridView2.DataSource = uow.Books.BookByCategory();
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.Columns[0].Width = 350;
                dataGridView2.Columns[1].Width = 150;
            }
        }
    }
}
