using BookStore.ModelsDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{

    public interface IAuthorRepository : IRepository<Author>
    {
        //firt who has maximum numbers of books
        IEnumerable TopAuthor(int count);
    }
}
