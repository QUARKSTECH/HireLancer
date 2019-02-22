using DataObjects.Back_Office;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [Authorize]
    public class ExternalController : ControllerBase
    {
        #region Pro-Services
        /// <summary>
        /// Get list of pro-servicess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ProServiceDto> Get()
        {
            var proServices = new List<ProServiceDto>();
            for (int index = 0; index < 15; index++)
            {
                proServices.Add(new ProServiceDto { Name = "Pro-service" + index.ToString() });
            }
            return proServices;
        }
        #endregion  Pro-Services
    }
}
