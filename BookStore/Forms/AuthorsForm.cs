using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class AuthorsForm : UserControl
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AuthorbtnClick_Click(object sender, EventArgs e)
        {
            //call unitofwork from implementations  ---  // instance bcbookstorecontext
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                Author author = new Author()
                {
                    Name = textBox1.Text,
                    Email = textBox2.Text,
                    Gender = Gm.Checked ? Gm.Text : Gf.Text
                };

                //added to collection author without inserting into DB
                uow.Authors.Add(author);
                int res = uow.Complete();
                if (res > 0)
                {
                    MessageBox.Show("Created ! id author is : " + author.IdAuthor);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            //call unitofwork from implementations  ---  // instance bcbookstorecontext
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {  // charge proprety books
                dataGridView1.DataSource = uow.Authors.Find(null, "Books")
                    .Select(p => new
                    {
                        idAuthor = p.IdAuthor,
                        Name = p.Name,
                        Gender = p.Gender,
                        nbBook = p.Books.Count()
                    }).ToList();

                dataGridView1.Columns["idAuthor"].Visible = false;

            }
        }
    }
}
