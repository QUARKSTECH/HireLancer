using BussinessLogicInterfaces;
using DomainEntities.External;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartUpController : BaseController
    {
        private readonly IStartUpInterface _startUpService;
        public StartUpController(IStartUpInterface startUpService)
        {
            _startUpService = startUpService;
        }

        //[Authorize]
        [HttpPost]
        public IActionResult AddStartUp(StartUpDto startUpDto)
        {
            var proService = _startUpService.AddStartUp(startUpDto);
            return Ok(proService);
        }

        //[Authorize]
        [HttpPut]
        public IActionResult EditStartUp(StartUpDto startUpDto)
        {
            var startUp = _startUpService.EditStartUp(startUpDto);
            return Ok(startUp);
        }

        //[Authorize]
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteStartUp(Guid id)
        {
            var result = _startUpService.DeleteStartUp(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}