using BookStore.ModelsDB;
using BookStore.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Implementations
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(bcBookStoreContext context) : base(context)
        {

        }
        public IEnumerable TopAuthor(int count)
        {
            throw new NotImplementedException();
        }
    }
}