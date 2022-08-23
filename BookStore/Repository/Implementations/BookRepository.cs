using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text; 
using Microsoft.EntityFrameworkCore; 
using System.Linq;

namespace BookStore.Repository.Implementations
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(bcBookStoreContext context) : base(context)
        {

        }

        public bcBookStoreContext _bcBookStoreContext { get => _context as bcBookStoreContext; }

        public IEnumerable BookByAuthor()
        {
            //get books by author
            return _bcBookStoreContext.Book.Include(a => a.Author)
                 .GroupBy(a => a.Author.Name)
                 .Select(grpAuthor => new { Author = grpAuthor.Key, Books = grpAuthor.Count() })
                 .OrderByDescending(a => a.Books)
                 .ToList();
        }

        public IEnumerable BookByCategory()
        {
            //get books by category
            return _bcBookStoreContext.Book.Include(a => a.Category)
             .GroupBy(a => a.Category.Categ)
             .Select(grpCateg => new { Category = grpCateg.Key, Books = grpCateg.Count() })
             .OrderByDescending(a => a.Books)
             .ToList();
        }
    }
}