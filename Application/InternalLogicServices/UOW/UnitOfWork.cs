using Database.Context;
using DataEntities.HelperField;
using InternalLogicIntefaces.GenericRepository;
using InternalLogicIntefaces.UnitOfWork;
using InternalLogicServices.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalLogicServices.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApiContext _apiContext;
        private IGenericRepository<HelperFields> _genericRepository;

        public UnitOfWork(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        IGenericRepository<HelperFields> IUnitOfWork.GenericRepository
        {
            get
            {
                return _genericRepository = _genericRepository ?? new GenericRepository<HelperFields>(_apiContext);
            }
        }

        public void Save()
        {
            _apiContext.SaveChanges();
        }
    }
}
