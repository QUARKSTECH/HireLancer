using DataEntities.HelperField;
using System;
using System.Linq;

namespace FacadeLayer.Interfaces
{
    public interface IKernel
    {
        IQueryable<T> GetEntities<T>(bool? active = true, bool includeDraft = false) where T : HelperFields;

        T GetEntityById<T>(long id) where T : HelperFields;

        T GetEntityById<T>(Guid id) where T : HelperFields;

        void AddEntity<T>(T entity, Action beforeInsert = null, bool isAutSave = false) where T : HelperFields;

        void UpdateEntity<T>(T entity, Action beforeInsert = null, bool isAutSave = false) where T : HelperFields;

        bool DeleteEntity<T>(Guid externalId, bool isAutoSave = false) where T : HelperFields;

        void Save(bool isAutoSave = true);

    }
}
