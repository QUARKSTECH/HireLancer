using DataEntities.HelperField;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace InternalLogicIntefaces.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : HelperFields
    {
        IQueryable<TEntity> GetManyQueryable<TEntity>(Func<TEntity, bool> where) where TEntity : HelperFields;

        TEntity Get<TEntity>(Func<TEntity, bool> where) where TEntity : HelperFields;

        IQueryable<TEntity> GetWithInclude<TEntity>(Expression<Func<TEntity, bool>> predicate, params string[] include) where TEntity : HelperFields;

        bool Exists<TEntity>(object primaryKey) where TEntity : HelperFields;

        void Update<TEntity>(TEntity entityToUpdate) where TEntity : HelperFields;

        void Insert<TEntity>(TEntity entity) where TEntity : HelperFields;

        bool Delete<TEntity>(TEntity entityToDelete, bool isSoftDelete = true) where TEntity : HelperFields;

        bool Delete<TEntity>(Func<TEntity, bool> where, bool isSoftDelete = true) where TEntity : HelperFields;

        void Save();
    }
}
