using Database.Context;
using DataEntities.HelperField;
using InternalLogicIntefaces.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace InternalLogicServices.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : HelperFields
    {
        private ApiContext _apiContext;

        public GenericRepository(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        public IQueryable<TEntity> GetManyQueryable<TEntity>(Func<TEntity, bool> where) where TEntity : HelperFields
        {
            return _apiContext.Set<TEntity>().Where(where).AsQueryable();
        }

        public TEntity Get<TEntity>(Func<TEntity, bool> where) where TEntity : HelperFields
        {
            return _apiContext.Set<TEntity>().Where(where).FirstOrDefault();
        }

        public IQueryable<TEntity> GetWithInclude<TEntity>(Expression<Func<TEntity, bool>> predicate, params string[] include) where TEntity : HelperFields
        {
            IQueryable<TEntity> query = _apiContext.Set<TEntity>();
            query = include.Aggregate(query, (current, inc) => current.Include(inc));
            return query.Where(predicate);
        }

        public bool Exists<TEntity>(object primaryKey) where TEntity : HelperFields
        {
            return _apiContext.Set<TEntity>().Find(primaryKey) != null;
        }

        public void Update<TEntity>(TEntity entityToUpdate) where TEntity : HelperFields
        {
            entityToUpdate.ModifiedBy = 1;
            entityToUpdate.ModifiedOn = DateTime.UtcNow;
            _apiContext.Set<TEntity>().Attach(entityToUpdate);
            _apiContext.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public void Insert<TEntity>(TEntity entity) where TEntity : HelperFields
        {
            entity.CreatedBy = 1; //TODO: Use login user id
            entity.CreatedOn = DateTime.UtcNow;
            entity.ExternalID = Guid.NewGuid();
            _apiContext.Set<TEntity>().Add(entity);
        }

        public bool Delete<TEntity>(TEntity entityToDelete, bool isSoftDelete = true) where TEntity : HelperFields
        {
            if (isSoftDelete)
            {
                entityToDelete.Active = false;
                Update(entityToDelete);
                return true;
            }
            else
            {
                return Delete(entityToDelete);
            }
        }

        private bool Delete<TEntity>(TEntity entityToDelete) where TEntity : HelperFields
        {
            if (_apiContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                _apiContext.Set<TEntity>().Attach(entityToDelete);
            }
            _apiContext.Set<TEntity>().Remove(entityToDelete);
            return true;
        }

        public bool Delete<TEntity>(Func<TEntity, bool> where, bool isSoftDelete = true) where TEntity : HelperFields
        {
            if (isSoftDelete)
            {
                IQueryable<TEntity> objects = _apiContext.Set<TEntity>().Where(where).AsQueryable();
                foreach (TEntity obj in objects)
                {
                    obj.Active = false;
                    Update(obj);
                }
                return true;
            }
            else
            {
                return Delete(where);
            }
        }

        private bool Delete<TEntity>(Func<TEntity, bool> where) where TEntity : HelperFields
        {
            IQueryable<TEntity> objects = _apiContext.Set<TEntity>().Where(where).AsQueryable();
            foreach (TEntity obj in objects)
            {
                _apiContext.Set<TEntity>().Remove(obj);
            }
            return true;
        }

        public void Save()
        {
            _apiContext.SaveChanges();
        }
    }
}
