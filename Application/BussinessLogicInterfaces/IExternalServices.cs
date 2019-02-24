using DataObjects.Back_Office;
using System.Collections.Generic;

namespace BussinessLogicInterfaces
{
    public interface IExternalServices
    {
        List<ProServiceDto> GetProServices();
    }
}
