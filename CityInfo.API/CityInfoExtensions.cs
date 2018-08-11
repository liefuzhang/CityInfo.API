using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name= "Central Park",
                            Description = "The most visited urban park in the US"
                        },
                        new PointOfInterest()
                        {
                            Name= "Empire state building",
                            Description = "A 102-storey skyscraper"
                        }
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name= "Eiffel Tower",
                            Description = "The most visited Tower"
                        },
                        new PointOfInterest()
                        {
                            Name= "The Louvre",
                            Description = "Museum"
                        }
                    }
                },
                new City()
                {
                    Name = "Beijing",
                    Description = "The one with that big nest.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name= "Bird Nest",
                            Description = "The most visited nest"
                        },
                        new PointOfInterest()
                        {
                            Name= "Forbidden city",
                            Description = "ancient royal palace"
                        }
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
