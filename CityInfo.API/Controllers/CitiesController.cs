using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }

        public IActionResult GetCities()
        {
            var cities = _cityInfoRepository.GetCities();
            var results = AutoMapper.Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cities);

            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest = false)
        {
            var cityToReturn = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                var cityResult = AutoMapper.Mapper.Map<CityDto>(cityToReturn);
                return Ok(cityResult);
            }

            return Ok(AutoMapper.Mapper.Map<CityWithoutPointsOfInterestDto>(cityToReturn));
        }
    }
}
