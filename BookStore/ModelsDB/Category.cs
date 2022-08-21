using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookStore.ModelsDB
{
    public partial class Category
    {
        public Category()
        {
            Book = new HashSet<Book>();
        }

        public Guid IdCateg { get; set; }
        public string Categ { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
