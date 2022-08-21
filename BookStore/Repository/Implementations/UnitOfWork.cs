using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Implementations
{
    //for consume and exectue repository
    public class UnitOfWork : IUnitOfWork
    {

        private readonly bcBookStoreContext _context;
        public IAuthorRepository Authors { get; private set; }

        public IBookRepository Books { get; private set; }

        public ICategoryRepository Categorys { get; private set; }

        //construct
        public UnitOfWork(bcBookStoreContext context)
        {
            _context = context;
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
            Categorys = new CategoryRepository(_context);
        }

        //save/commit in DB method
        public int Complete()
        {
            return _context.SaveChanges();
        }


        //dispose method
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}