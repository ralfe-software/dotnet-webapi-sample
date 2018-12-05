using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<int>> Get()
        {
            var r = new Random();
            
            var gameNumbers = new int[6];

            for (int i = 0; i < gameNumbers.Length; i++)
            {
                gameNumbers[i] = r.Next(1, 50);
            }

            return gameNumbers;
        }
    }
}
