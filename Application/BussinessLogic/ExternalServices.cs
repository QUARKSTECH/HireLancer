using BussinessLogicInterfaces;
using DataObjects.Back_Office;
using System;
using System.Collections.Generic;

namespace BussinessLogic
{
    public class ExternalServices : IExternalServices
    {
        public List<ProServiceDto> GetProServices()
        {
            var proServices = new List<ProServiceDto>();
            for (int index = 0; index < 15; index++)
            {
                proServices.Add(new ProServiceDto { Name = "Pro-service" + index.ToString() });
            }
            return proServices;
        }
    }
}
