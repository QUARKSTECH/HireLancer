using DataEntities.HelperField;
using System;
using System.Linq;

namespace BussinessLogicInterfaces.Core
{
    public interface IServiceInterface
    {
        IQueryable<T> GetEntities<T>(bool? active = true, bool includeDraft = false) where T : HelperFields;
        T GetEntityById<T>(Guid id) where T : HelperFields;
        T GetEntityById<T>(long id) where T : HelperFields;

        void AddEntity<T>(T entity, Action beforeInsert = null, Action afterInsert = null, bool isAutoSave = false) where T : HelperFields;

        void UpdateEntity<T>(T entity, Action beforeInsert = null, Action afterInsert = null, bool isAutoSave = false) where T : HelperFields;

        bool DeleteEntity<T>(Guid id, bool isAutoSave = false) where T : HelperFields;

        void SaveChanges();
    }
}
