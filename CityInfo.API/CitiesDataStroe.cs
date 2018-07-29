using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStroe
    {
        public static CitiesDataStroe Current { get; } = new CitiesDataStroe();

        public List<CityDto > Cities { get; set; }

        public CitiesDataStroe()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name= "Central Park",
                            Description = "The most visited urban park in the US"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name= "Empire state building",
                            Description = "A 102-storey skyscraper"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name= "Eiffel Tower",
                            Description = "The most visited Tower"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name= "The Louvre",
                            Description = "Museum"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Beijing",
                    Description = "The one with that big nest.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name= "Bird Nest",
                            Description = "The most visited nest"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name= "Forbidden city",
                            Description = "ancient royal palace"
                        }
                    }
                }
            };
        }
    }
}
