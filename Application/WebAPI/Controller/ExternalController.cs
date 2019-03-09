using BussinessLogicInterfaces;
using DomainEntities.External;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI.Controller
{
    [Route("api")]
    [ApiController]
    public class ExternalController : BaseController
    {
        private readonly IProServiceInterface _proService;
        private readonly IStartUpInterface _startUpService;
        public ExternalController(IProServiceInterface proService, IStartUpInterface startUpService)
        {
            _proService = proService;
            _startUpService = startUpService;
        }

        [HttpGet]
        [Route("proservice/all")]
        public List<ProServiceDto> GetProServices()
        {
            return _proService.GetProServices();
        }

        [HttpGet]
        [Route("proservice/{id}")]
        public IActionResult GetProServiceById(Guid id)
        {
            var proService = _proService.GetProServiceById(id);
            return Ok(proService);
        }


        [HttpGet]
        [Route("startup/all")]
        public List<StartUpDto> GetStartUps()
        {
            return _startUpService.GetStartUps();
        }

        [HttpGet]
        [Route("startup/{id}")]
        public IActionResult GetStartUpById(Guid id)
        {
            var startUp = _startUpService.GetStartUpById(id);
            return Ok(startUp);
        }
    }
}