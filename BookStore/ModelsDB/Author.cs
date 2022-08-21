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
            //change book to books
            Books = new HashSet<Book>();
        }

        public Guid IdAuthor { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        //change book par default to books
        public virtual ICollection<Book> Books { get; set; }
    }
}
