using DataEntities.HelperField;
using FacadeLayer.Interfaces;
using InternalLogicIntefaces.Persistence;
using System;
using System.Linq;

namespace FacadeLayer.Services
{
    public class Kernel : IKernel
    {
        #region Private properties
        private readonly IPersistence _persistence;
        #endregion Private properties

        public Kernel(IPersistence persistence)
        {
            this._persistence = persistence;
        }

        public IQueryable<T> GetEntities<T>(bool? active = true, bool includeDraft = false) where T : HelperFields
        {
            return _persistence.GetEntities<T>(active, includeDraft);
        }

        public T GetEntityById<T>(Guid id) where T : HelperFields
        {
            return _persistence.GetEntityById<T>(id);
        }

        public T GetEntityById<T>(long id) where T : HelperFields
        {
            return _persistence.GetEntityById<T>(id);
        }

        public void AddEntity<T>(T entity, Action beforeInsert = null, bool isAutoSave = false) where T : HelperFields
        {
            _persistence.AddEntity<T>(entity, beforeInsert);
            Save(isAutoSave);
        }

        public void UpdateEntity<T>(T entity, Action beforeInsert = null, bool isAutoSave = false) where T : HelperFields
        {
            _persistence.UpdateEntity<T>(entity, beforeInsert);
            Save(isAutoSave);
        }

        public bool DeleteEntity<T>(Guid id, bool isAutoSave = false) where T : HelperFields
        {
            var result = _persistence.DeleteEntity<T>(id);
            Save(isAutoSave);
            return result;
        }

        public void Save(bool isAutoSave = true)
        {
            if (isAutoSave)
            {
                _persistence.Save();
            }
        }
    }
}
