using BussinessLogicInterfaces;
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
    //[Authorize]
    public class ExternalController : ControllerBase
    {
        private readonly  IExternalServices _externalServices;
        public ExternalController(IExternalServices externalServices)
        {
            _externalServices = externalServices;
        }

        #region Pro-Services
        /// <summary>
        /// Get list of pro-servicess
        /// </summary>
        /// <returns></returns>
        [HttpGet("getproServices")]
        public IEnumerable<ProServiceDto> Get()
        {
           return _externalServices.GetProServices();
        }
        #endregion  Pro-Services
    }
}
