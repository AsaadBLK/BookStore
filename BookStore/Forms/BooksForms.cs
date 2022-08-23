using BookStore.ModelsDB;
using BookStore.ModelsHelpers;
using BookStore.Repository.Implementations;
using LinqKit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static BookStore.SharedData;

namespace BookStore.Forms
{
    public partial class BooksForms : UserControl
    {
        private int TotalPages = 0;
        private Page page;
        private IEnumerable<BookViewModel> listbooks;
        public BooksForms()
        {
            InitializeComponent();
            int nbElemByPage = Convert.ToInt32(ConfigurationManager.AppSettings["nbElemByPage"]);
            page = new Page() { pageIndex = 1, pageSize = nbElemByPage };
        }


        public void ReloadData()
        {

            //multi filtre, get all books into predicate
            var predicate = PredicateBuilder.New<Book>(true);

            //get values from controles txt combobox ...
            string title = txttitlecr.Text.ToLower();
            string category = txtcategoryCr.Text.ToLower();
            Author author = (Author)txtauthorCr.SelectedItem;
            //  idautor selected
            Guid idAuthor = (author == null) ? Guid.Empty : author.IdAuthor;

            if (!String.IsNullOrEmpty(title))
                // old value of predicate add also title if it is exist
                predicate = predicate.And(b => b.Title.ToLower().Contains(title));

            if (!String.IsNullOrEmpty(category))
                predicate = predicate.And(b => b.Category.Categ.ToLower().Contains(category));

            if (idAuthor != Guid.Empty)
                predicate = predicate.And(b => b.IdAuthor == idAuthor);

            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                var list = uow.Books.Find(predicate, "Author,Category", page)
                    .Select(p => new BookViewModel
                    {
                        IdBook = p.IdBook,
                        Title = p.Title,
                        Description = p.DescBook,
                        Price = (double)p.Price,
                        NbPages = (int)p.NbPages,
                        Published = (DateTime)p.PublishedDate,
                        Categorie = p.Category.Categ,
                        Author = p.Author.Name
                    }).ToList();

                dataGridView1.DataSource = list;

                listbooks = list;
            }

            dataGridView1.Columns["IdBook"].Visible = false;

            labbooks.Text = dataGridView1.RowCount.ToString();

            AddColumnIcon(dataGridView1, "icons8-add-new-24", "icons8-add-new-24");
            AddColumnIcon(dataGridView1, "icons8-plugin-30", "icons8-plugin-30");
            AddColumnIcon(dataGridView1, "icons8-remove-24", "icons8-remove-24");




        }

        private void BooksForms_Load(object sender, EventArgs e)
        {
            //using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            //{
            //    var list = uow.Books.Find(null, "Author,Category", null)
            //        .Select(p => new
            //        {
            //            IdBook = p.IdBook,
            //            Title = p.Title,
            //            DescBook = p.DescBook,
            //            Cover = p.Cover,
            //            Published = p.PublishedDate,
            //            Price = p.Price,
            //            NbPages = p.NbPages
            //        }
            //    ).ToList();

            //}


            ReloadData();
            CalculateTotalPages(page);
            dataGridView1.Columns["IdBook"].Visible = false; 
            labbooks.Text = dataGridView1.RowCount.ToString();

            AddColumnIcon(dataGridView1, "icons8-add-new-24", "icons8-add-new-24");
            AddColumnIcon(dataGridView1, "icons8-plugin-30", "icons8-plugin-30");
            AddColumnIcon(dataGridView1, "icons8-remove-24", "icons8-remove-24");



             
            //SetWitdthDataGridView(dataGridView1, columnsDgvBooks);
            txtauthorCr.Items.Add(new Author() { IdAuthor = Guid.Empty, Name = "-- All  Authors --" });
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                foreach (var item in uow.Authors.GetAll())
                {
                    txtauthorCr.Items.Add(item);
                }
                txtauthorCr.ValueMember = "IdAuthor";
                txtauthorCr.DisplayMember = "Name";
                txtauthorCr.SelectedIndex = 0;
            }
             
        }





        private void CalculateTotalPages(Page page)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                TotalPages = (int)Math.Ceiling((double)uow.Books.GetAll().Count() / page.pageSize);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
           

            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
               DataGridViewRow CurrentRow = dataGridView1.Rows[e.RowIndex];
                CurrentRow.Selected = true;

                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                Guid idBook = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IdBook"].Value.ToString());
                if (colName == "icons8-remove-24")
                {
                    bool confirm = ConfirmDelete("Voulez vous vraiment supprimer ce Livre ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                        {
                            Book book = uow.Books.Get(idBook);
                            uow.Books.Remove(book);
                            uow.Complete();
                            ReloadData();
                        }
                    }
                }
                if (colName == "icons8-add-new-24")
                {
                    BookNewEditForm bookEditform = new BookNewEditForm(this, idBook);
                    bookEditform.ShowDialog();
                }

                //if (colName == "print")
                //{
                //    using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                //    {
                //        Book book = uow.Books.Find(p => p.IdBook == idBook, "Category,Author").FirstOrDefault();
                //        BookViewModel bv = new BookViewModel()
                //        {
                //            IdBook = book.IdBook,
                //            Title = book.Title,
                //            Description = book.DescBook,
                //            Price = (float)book.Price,
                //            NbPages = (int)book.NbPages,
                //            Published = (DateTime)book.PublishedDate,
                //            Categorie = book.Category.Categ,
                //            Author = book.Author.Name,
                //            Cover = book.Cover
                //        };
                //        var props = typeof(BookViewModel).GetProperties();
                //        var dt = new DataTable();
                //        dt.Columns.AddRange(
                //            props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
                //            );
                //        dt.Rows.Add(props.Select(p => p.GetValue(bv, null)).ToArray());

                //        string RptPath = @"Reports\BookDetail.rdlc";
                //        string NameSrcRpt = "ds_BookDetail";
                //        string fileName = "BookDetail";
                //        PrintToPDF(RptPath, NameSrcRpt, dt, fileName);
                //    }
                //}

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookNewEditForm bnf = new BookNewEditForm(this);
            bnf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReloadData();
        }





         
         

        private void firstbtn_Click_1(object sender, EventArgs e)
        {
            page.pageIndex = 1;
            txtcurrentpage.Text = $"Page {page.pageIndex} / {TotalPages}";
            ReloadData();
        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (page.pageIndex > 1)
            {
                page.pageIndex--;
                txtcurrentpage.Text = $"Page {page.pageIndex} / {TotalPages}";
                ReloadData();
            }
        }

        private void lastbtn_Click(object sender, EventArgs e)
        {
            page.pageIndex = TotalPages;
            txtcurrentpage.Text = $"Page {page.pageIndex} / {TotalPages}";
            ReloadData();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (page.pageIndex < TotalPages)
            {
                page.pageIndex++;
                txtcurrentpage.Text = $"Page {page.pageIndex} / {TotalPages}";
                ReloadData();
            }
        }
    }
}
