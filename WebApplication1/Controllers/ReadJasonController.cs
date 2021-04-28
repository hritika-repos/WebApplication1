using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ReadJasonController : ControllerBase
    {
        // GET: api/<ReadJasonController>
        //[HttpGet]
        //public string Get()
        //{

        //    string allText = System.IO.File.ReadAllText(@"C:\Users\vinay\source\repos\WebApplication1\WebApplication1\tableinformation.json");

            
        //    return allText;
           
        //}

        public  tableinformation  _appSettings;

        
        
        
        public ReadJasonController(IOptions<tableinformation> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        [HttpGet]

     
        public ActionResult Get()
        {


            var employee = new tableinformation()
            {
                name = _appSettings.name,
                Project = _appSettings.Project,
                Country = _appSettings.Country,
                Email = _appSettings.Email,
                Technology = _appSettings.Technology

            };
        var listOfEmployees = new List<tableinformation>();
        listOfEmployees.Add(employee);

            return Ok(listOfEmployees);
        }








    // GET api/<ReadJasonController>/5
    
    }
}
