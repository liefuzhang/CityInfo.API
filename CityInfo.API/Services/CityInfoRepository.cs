﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Entities;
using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

        public City GetCity(int cityId, bool includePointsOfInterest)
        {
            if (includePointsOfInterest)
            {
                return _context.Cities.Include(c => c.PointsOfInterest).SingleOrDefault(c => c.Id == cityId);
            }

            return _context.Cities.SingleOrDefault(c => c.Id == cityId);
        }

        public bool CityExists(int cityId) {
            return _context.Cities.Any(c => c.Id == cityId);
        }

        public IEnumerable<PointOfInterest> GetPointOfInterests(int cityId)
        {
            return _context.PointsOfInterest.Where(p => p.CityId == cityId).ToList();
        }

        public PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId)
        {
            return _context.PointsOfInterest.SingleOrDefault(p => p.CityId == cityId && p.Id == pointOfInterestId);
        }

        public void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest) {
            var city = GetCity(cityId, false);
            city.PointsOfInterest.Add(pointOfInterest);
        }

        public void DeletePointOfInterest(PointOfInterest pointOfInterest) {
            _context.PointsOfInterest.Remove(pointOfInterest);
        }

        public bool Save() {
            return (_context.SaveChanges() >= 0);
        }
    }
}
