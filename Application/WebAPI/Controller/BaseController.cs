using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        //[HttpGet]
        //[Route("Index")]
        //public IActionResult Index()
        //{
        //    return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),
        //        "wwwroot", "index.html"), "text/HTML");
        //}
    }
}
