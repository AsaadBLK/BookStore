using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BookStore.ModelsHelpers;

namespace BookStore.Repository.Interfaces
{
    // interface generic
    //contain actions common with all models and their methods : add/upd/get/delete
    public interface IRepository<TEntity> where TEntity : class
    {
        // get id 'global united identified' of all model as author,book,category ...
        TEntity Get(Guid id);

        //get list of a model as author,book,category ...
        IEnumerable<TEntity> GetAll();

        //get list of a model with parametres using lambda expression also delegate func => as author,book,category ...  also add paggination
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null, string includeProperties = null, Page page = null);

        //add method
        void Add(TEntity entity);

        //add collection/list of data in entity
        void AddRange(IEnumerable<TEntity> entities);

        //remove method
        void Remove(TEntity entity);

        //remove collection/list of data in entity
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
