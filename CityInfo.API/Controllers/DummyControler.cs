using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    public class DummyControlers : Controller
    {
        private CityInfoContext _ctx;

        public DummyControlers(CityInfoContext ctx)
        {
            _ctx = ctx;
        }

        [Route("api/textdatabase")]
        public IActionResult TestDB()
        {
            return Ok();
        }
    }
}
