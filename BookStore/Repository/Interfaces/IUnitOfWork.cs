using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Interfaces
{
    
    public interface IUnitOfWork : IDisposable
    {
        //propreties linked to other Irepositories
        IAuthorRepository Authors { get; }
        IBookRepository Books { get; }
        ICategoryRepository Categorys { get; }


        // for save/commit method
        int Complete();
    }
}
