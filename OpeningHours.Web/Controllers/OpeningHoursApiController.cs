using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpeningHours.Lib;

namespace OpeningHours.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningHoursApiController : ControllerBase
    {
        [HttpGet]
        public bool IsOpenAt([FromQuery] int year, [FromQuery]int month, [FromQuery]int day, [FromQuery]int hour, [FromQuery]int minute)
        {
            var sut = new OpeningHoursChecker();
            DateTime adate = new DateTime(year, month, day, hour, minute, 0);
            return sut.IsOpenAt(adate);
        }
    }
}