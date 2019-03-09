using BussinessLogicInterfaces;
using DomainEntities.External;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controller
{
    [Route("api/proservice")]
    [ApiController]
    public class ProServiceController : BaseController
    {
        private readonly IProServiceInterface _proService;
        public ProServiceController(IProServiceInterface proService)
        {
            _proService = proService;
        }

        //[Authorize]
        [HttpPost]
        public IActionResult AddProService(ProServiceDto proServiceDto)
        {
            var proService = _proService.AddProService(proServiceDto);
            return Ok(proService);
        }

        //[Authorize]
        [HttpPut]
        public IActionResult EditProService(ProServiceDto proServiceDto)
        {
            var proService = _proService.EditProService(proServiceDto);
            return Ok(proService);
        }

        //[Authorize]
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProService(Guid id)
        {
            var result = _proService.DeleteProService(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}