using DomainEntities.External;
using System;
using System.Collections.Generic;

namespace BussinessLogicInterfaces
{
    public interface IStartUpInterface
    {
        List<StartUpDto> GetStartUps();

        StartUpDto GetStartUpById(Guid id);

        StartUpDto AddStartUp(StartUpDto startUpDto);

        StartUpDto EditStartUp(StartUpDto startUpDto);

        bool DeleteStartUp(Guid id);

    }
}
