using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookStore.ModelsDB
{
    public partial class Author
    {
        public Author()
        {
            Book = new HashSet<Book>();
        }

        public Guid IdAuthor { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
