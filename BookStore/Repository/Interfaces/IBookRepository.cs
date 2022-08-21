using BookStore.ModelsDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{

    //add the operations needed for each model

    //interface public implement the irepository
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable BookByCategory();
        IEnumerable BookByAuthor();
    }

}
