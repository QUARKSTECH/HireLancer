using DataEntities.HelperField;
using System;
using System.Linq;

namespace InternalLogicIntefaces.Persistence
{
    public interface IPersistence
    {
        IQueryable<T> GetEntities<T>(bool? active = true, bool includeDraft = false) where T : HelperFields;

        void AddEntity<T>(T entity, Action action = null) where T : HelperFields;

        void UpdateEntity<T>(T entity, Action action = null) where T : HelperFields;

        T GetEntityById<T>(Guid id) where T : HelperFields;

        bool DeleteEntity<T>(Guid externalId) where T : HelperFields;

        T GetEntityById<T>(long id) where T : HelperFields;

        void Save();

    }
}
