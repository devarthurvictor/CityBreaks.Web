﻿using CityBreaks.Web.Data;
using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Services
{
    public class CityService : ICityService
    {
        private readonly CityBreaksContext _context;

        public CityService(CityBreaksContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await _context.Cities
                .Include(c => c.Properties)
                .ToListAsync();
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _context.Cities
                .Include(c => c.Country)
                .Include(c => c.Properties.Where(p => p.DeletedAt == null))
                .ToListAsync();
        }
    }
}
