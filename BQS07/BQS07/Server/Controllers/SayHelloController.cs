using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BQS07.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("{yourName}")]
        public string Get(string yourName)
        {
            return $"{yourName} 你好，這裡是 ASP.NET Core Web API";
        }
    }
}
