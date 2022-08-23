using BookStore.ModelsDB;
using BookStore.Repository.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static BookStore.SharedData; 

namespace BookStore.Forms
{
    public partial class BookNewEditForm : Form
    {
        private readonly BooksForms bookforms;
        private readonly Guid IdBookUp;
        bool vTitle, vDescription, vPrice, vNbPages;


        public BookNewEditForm()
        {
            InitializeComponent();
        }

        //optional idbook for update or add
        public BookNewEditForm(BooksForms Pbookforms, [Optional] Guid IdBook)
        {
            InitializeComponent();
            this.bookforms = Pbookforms;
            //idbook from parametre of bookform if it is empty then got it
            if (IdBook != Guid.Empty) this.IdBookUp = IdBook;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images |*.jpg; *.jpeg; *.png; *.bmp";
            ofd.Title = "Sélectionner une image de couveture ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageCover.Image = new Bitmap(ofd.FileName);
                label9.Text = ofd.FileName;
            }
        }

        private void bookbtnClick_Click(object sender, EventArgs e)
        {

            txttitre_Validating(sender, e as CancelEventArgs);
            txtdesc_Validating(sender, e as CancelEventArgs);
            txtprice_Validating(sender, e as CancelEventArgs);
            txtnbpages_Validating(sender, e as CancelEventArgs);

            //control of data entry
            if (vTitle && vDescription && vPrice && vNbPages)
            {
                using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
                {
                    string title = txttitre.Text;
                    string descBook = txtdesc.Text;
                    DateTime publishedDate = dateTimePicker1.Value.Date;
                    double price = Convert.ToDouble(txtprice.Text);
                    int nbPages = Convert.ToInt32(txtnbpages.Text);
                    Guid idAuthor = Guid.Parse(combauth.SelectedValue.ToString());
                    Guid idCateg = Guid.Parse(combcat.SelectedValue.ToString());
                    /************************** Adding Book ********************************/
                    if (IdBookUp == Guid.Empty)
                    {
                        Book book = new Book()
                        {
                            Title = title,
                            DescBook = descBook,
                            PublishedDate = publishedDate,
                            Price = price,
                            NbPages = nbPages,
                            IdAuthor = idAuthor,
                            IdCateg = idCateg,
                            Cover = (!String.IsNullOrEmpty(label9.Text) ? ConvertToBinaryFromFile(label9.Text) : null)
                        };
                        uow.Books.Add(book);
                    }
                    /************************** Editng a Book ********************************/
                    else
                    {
                        Book book = uow.Books.Get(IdBookUp);
                        book.Title = title;
                        book.DescBook = descBook;
                        book.PublishedDate = publishedDate;
                        book.Price = price;
                        book.NbPages = nbPages;
                        book.IdAuthor = idAuthor;
                        book.IdCateg = idCateg;
                        book.Cover = (!String.IsNullOrEmpty(label9.Text) ? ConvertToBinaryFromFile(label9.Text) : book.Cover);
                    }

                    if (uow.Complete() > 0)
                    {
                        this.Close();
                        bookforms.ReloadData();
                    }
                }
           } 

        }

       
        private void BookNewEditForm_Load(object sender, EventArgs e)
        { 
          label9.Text = "";
            using (UnitOfWork uow = new UnitOfWork(new bcBookStoreContext()))
            {
                combauth.DataSource = uow.Authors.GetAll();
                combauth.ValueMember = "IdAuthor";
                combauth.DisplayMember = "Name";
                combcat.DataSource = uow.Categorys.GetAll();
                combcat.ValueMember = "IdCateg";
                combcat.DisplayMember = "Categ";
                if (IdBookUp != Guid.Empty)
                { 
                    bookbtnClick.Text = "Update Book";
                    //get book which has the idbook arrived from bookform
                    Book book = uow.Books.Get(IdBookUp);
                   
                    txttitre.Text = book.Title;
                    txtdesc.Text = book.DescBook;
                    dateTimePicker1.Value = book.PublishedDate.Value;
                    txtprice.Text = book.Price.ToString();
                    txtnbpages.Text = book.NbPages.ToString();
                    combauth.SelectedItem = book.Author;
                    combcat.SelectedItem = book.Category;
                    if (book.Cover != null)
                    {
                        //display cover image from DB
                        MemoryStream ms = new MemoryStream(book.Cover);
                        txtImageCover.Image = Image.FromStream(ms);
                    }

                }

            }
        }




        private void txttitre_Validating(object sender, CancelEventArgs e)
        {
            vTitle = ValidateData(errProvider, txttitre, "Value of title not correct !!!", bookbtnClick);
        }
        private void txtdesc_Validating(object sender, CancelEventArgs e)
        {
            vDescription = ValidateData(errProvider, txtdesc, "Value of Description not correct !!!", bookbtnClick);

        }

        private void txtprice_Validating(object sender, CancelEventArgs e)
        {
            vPrice = ValidateData(errProvider, txtprice, "Value of price  not correct !!!", bookbtnClick, true);

        }

        private void txtnbpages_Validating(object sender, CancelEventArgs e)
        {
            vNbPages = ValidateData(errProvider, txtnbpages, "Value of nbPages  not correct !!!", bookbtnClick, true);

        }






    }
}
