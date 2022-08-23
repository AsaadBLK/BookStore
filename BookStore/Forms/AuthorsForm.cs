using BookStore.ModelsDB;
using BookStore.ModelsHelpers;
using BookStore.Repository.Implementations;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static BookStore.SharedData;
namespace BookStore.Forms
{
    public partial class AuthorsForm : UserControl
    {
        public AuthorsForm()
        {
            InitializeComponent();
        }


        private Guid idAuthorUp;


        private void LoadData(UnitOfWork uow)
        {
            dataGridView1.DataSource = uow.Authors.Find(null, "Books").Select(p => new
            {
                p.IdAuthor,
                p.Name,
                p.Email,
                p.Gender,
                nbBooks = p.Books.Count()
            }).ToList();
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

                    //MessageBox.Show("Author created successfully ID : " + author.IdAuthor, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(uow);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                    Gm.Select();
                    nbauthors.Text = dataGridView1.RowCount.ToString();
                }
            }
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {

            textBox1.Focus();
            Gm.Select();
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                LoadData(uow); 
                dataGridView1.Columns["IdAuthor"].Visible = false;
                dataGridView1.Columns["Name"].Width = 300;
                dataGridView1.Columns["Email"].Width = 300;
                dataGridView1.Columns["Gender"].Width = 100;
                dataGridView1.Columns["nbBooks"].Width = 100;
                dataGridView1.RowHeadersVisible = false;
                AddColumnIcon(dataGridView1, "icons8-plugin-30", "icons8-plugin-30");
                AddColumnIcon(dataGridView1, "icons8-remove-24", "icons8-remove-24");
                nbauthors.Text = dataGridView1.RowCount.ToString();
                updatebtn.Visible = false;
            }

            ////call unitofwork from implementations  ---  // instance bcbookstorecontext
            //using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            //{  // charge proprety books
            //    dataGridView1.DataSource = uow.Authors.Find(null, "Books")
            //        .Select(p => new
            //        {
            //            idAuthor = p.IdAuthor,
            //            Name = p.Name,
            //            Email = p.Email,
            //            Gender = p.Gender,
            //            nbBook = p.Books.Count()
            //        }).ToList();

            //    nbauthors.Text = dataGridView1.RowCount.ToString();

            //    SharedData.AddColumnIcon(dataGridView1, "icons8-plugin-30", "icons8-plugin-30");
            //    SharedData.AddColumnIcon(dataGridView1, "icons8-remove-24", "icons8-remove-24");

            //    dataGridView1.Columns["idAuthor"].Visible = false;
 
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name.ToString();

                if (colName != "icons8-plugin-30" && colName != "icons8-remove-24")
                {
                    dataGridView1.Cursor = Cursors.Default;
                }
                else
                {
                    //sur le cursor de update and delete
                    dataGridView1.Cursor = Cursors.Hand;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                Guid idAuthor = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                if (colName == "icons8-remove-24")
                {
                    bool confirm = ConfirmDelete("Voulez vous vraiment supprimer cet auteur  ?");
                    if (confirm)
                    {
                        using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                        {
                            Author author = uow.Authors.Get(idAuthor);
                            uow.Authors.Remove(author);
                            uow.Complete();
                            LoadData(uow);
                            dataGridView1.Text = dataGridView1.RowCount.ToString();
                        }
                    }

                }



                //if (colName == "print")
                //{
                //    using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                //    {
                //        Author author = uow.Authors.Find(a => a.IdAuthor == idAuthor, "Books").FirstOrDefault();
                //        AuthorViewModel av = new AuthorViewModel()
                //        {
                //            IdAuthor = author.IdAuthor,
                //            Name = author.Name,
                //            Email = author.Email,
                //            Gender = author.Gender,
                //            nbBooks = author.Books.Count
                //        };
                //        DataTable dt = new DataTable();
                //        var props = typeof(AuthorViewModel).GetProperties();
                //        dt.Columns.AddRange(
                //           props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
                //            );
                //        dt.Rows.Add(props.Select(p => p.GetValue(av, null)).ToArray());

                //        string RptPath = @"Reports\ListAuthors.rdlc";
                //        string NameSrcRpt = "ds_listAuthors";

                //        string fileName = "ListAuthors";
                //        PrintToPDF(RptPath, NameSrcRpt, dt, fileName, true);

                //        }

                //    }

                //end dataGridView1_CellContentClick method

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAuthorUp = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells["IdAuthor"].Value.ToString());
                using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                {
                    Author auth = uow.Authors.Get(idAuthorUp);
                    textBox1.Text = auth.Name;
                    textBox2.Text = auth.Email;
                    Gm.Checked = (auth.Gender == "M") ? true : false;
                    Gf.Checked = (auth.Gender == "F") ? true : false;
                    AuthorbtnClick.Visible = true;
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                Author auth = uow.Authors.Get(idAuthorUp);
                auth.Name = textBox1.Text;
                auth.Email = textBox2.Text;
                auth.Gender = Gm.Checked ? Gm.Text : Gf.Text;
                uow.Complete();
                LoadData(uow);
                updatebtn.Visible = false;
            }
        }
    }
}



 