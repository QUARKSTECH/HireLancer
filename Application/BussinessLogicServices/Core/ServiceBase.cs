using AutoMapper;
using BussinessLogicInterfaces.Core;
using DataEntities.HelperField;
using FacadeLayer.Interfaces;
using System;
using System.Linq;
using System.Transactions;

namespace BussinessLogicServices.Core
{
    public class ServiceBase : IServiceInterface
    {
        #region Private properties
        public IKernel _kernel;
        protected IMapper _mapper;
        #endregion Private properties
        public ServiceBase(IKernel kernel, IMapper mapper)
        {
            this._kernel = kernel;
            this._mapper = mapper;
        }

        public IQueryable<T> GetEntities<T>(bool? active = true, bool includeDraft = false) where T : HelperFields
        {
            return _kernel.GetEntities<T>(active, includeDraft);
        }

        public T GetEntityById<T>(Guid id) where T : HelperFields
        {
            return _kernel.GetEntityById<T>(id);
        }

        public T GetEntityById<T>(long id) where T : HelperFields
        {
            return _kernel.GetEntityById<T>(id);
        }

        public void AddEntity<T>(T entity, Action beforeInsert = null, Action afterInsert = null, bool isAutoSave = false) where T : HelperFields
        {
            _kernel.AddEntity(entity, beforeInsert, isAutoSave);
            afterInsert?.Invoke();
        }

        public void UpdateEntity<T>(T entity, Action beforeInsert = null, Action afterInsert = null, bool isAutoSave = false) where T : HelperFields
        {
            _kernel.UpdateEntity(entity, beforeInsert, isAutoSave);
            afterInsert?.Invoke();
        }

        public bool DeleteEntity<T>(Guid id, bool isAutoSave = false) where T : HelperFields
        {
            return _kernel.DeleteEntity<T>(id, isAutoSave);
        }

        public void SaveChanges()
        {
            using (var scope = new TransactionScope())
            {
                _kernel.Save();
                scope.Complete();
            }
        }

    }
}
