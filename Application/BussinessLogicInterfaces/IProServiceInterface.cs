using DomainEntities.External;
using System;
using System.Collections.Generic;

namespace BussinessLogicInterfaces
{
    public interface IProServiceInterface
    {
        List<ProServiceDto> GetProServices();

        ProServiceDto GetProServiceById(Guid id);

        ProServiceDto AddProService(ProServiceDto proServiceDto);

        ProServiceDto EditProService(ProServiceDto proServiceDto);

        bool DeleteProService(Guid id);

    }
}
