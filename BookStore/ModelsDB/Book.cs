using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookStore.ModelsDB
{
    public partial class Book
    {
        public Guid IdBook { get; set; }
        public Guid IdAuthor { get; set; }
        public Guid IdCateg { get; set; }
        public string Title { get; set; }
        public string DescBook { get; set; }
        public byte[] Cover { get; set; }
        public DateTime? PublishedDate { get; set; }
        public double? Price { get; set; }
        public int? NbPages { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
