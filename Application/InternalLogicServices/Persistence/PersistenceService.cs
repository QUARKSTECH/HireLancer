using DataEntities.HelperField;
using InternalLogicIntefaces.Persistence;
using InternalLogicIntefaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace InternalLogicServices.Persistence
{
    public class PersistenceService : IPersistence
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersistenceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Get entities

        public IQueryable<T> GetEntities<T>(bool? active = true, bool includeDraft = false) where T : HelperFields
        {
            return _unitOfWork.GenericRepository.GetManyQueryable<T>(entities => entities.Active == active && entities.IsDraft == includeDraft);
        }

        //public IQueryable<T> GetEntitiesByIds<T>(bool? active = true, bool includeDraft = false, List<long> ids = null, List<Guid> externalIds = null) where T : HelperFields
        //{
        //    IQueryable<T> result = GetEntities<T>(active, includeDraft);
        //    if (ids != null)
        //    {

        //    }
        //    else if (externalIds != null)
        //    {

        //    }
        //    return result;
        //}

        public T GetEntityById<T>(long id) where T : HelperFields
        {
            return _unitOfWork.GenericRepository.Get<T>(entity => entity.Id == id);
        }

        public T GetEntityById<T>(Guid id) where T : HelperFields
        {
            return _unitOfWork.GenericRepository.Get<T>(entity => entity.ExternalID == id);
        }

        public IQueryable<T> GetWithInclude<T>(Expression<Func<T, bool>> predicate, params string[] include) where T : HelperFields
        {
            return _unitOfWork.GenericRepository.GetWithInclude<T>(predicate, include);
        }

        #endregion Get entities

        public void AddEntity<T>(T entity, Action action = null) where T : HelperFields
        {
            action?.Invoke();           
            _unitOfWork.GenericRepository.Insert(entity);
        }

        public void UpdateEntity<T>(T entity, Action action = null) where T : HelperFields
        {
            action?.Invoke();
            _unitOfWork.GenericRepository.Update(entity);
        }

        public bool DeleteEntity<T>(Guid id) where T : HelperFields
        {
            return _unitOfWork.GenericRepository.Delete<T>(entity => entity.ExternalID == id);
        }

        public void Save()
        {
            _unitOfWork.GenericRepository.Save();
        }
    }
}
