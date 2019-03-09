using DataEntities.HelperField;
using InternalLogicIntefaces.GenericRepository;

namespace InternalLogicIntefaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<HelperFields> GenericRepository { get; }

        //void BeginTransaction();
        //void Commit();
        //void Rollback();
    }
}
