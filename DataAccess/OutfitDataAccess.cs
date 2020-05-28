using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignManagement.DataAccess
{
    public class OutfitDataAccessLayer
    {
        public interface IOutfitService
        {
            Task<List<Outfit>> Get();
            Task<Outfit> Get(int id);
            Task<Outfit> Add(Outfit outfit);
            Task<Outfit> Update(Outfit outfit);
            Task<Outfit> Delete(int id);
        }
        public class OutfitService : IOutfitService
        {
            private readonly DesignMgmtContext _context;

            public OutfitService(DesignMgmtContext context)
            {
                _context = context;
            }
            public async Task<List<Outfit>> Get()
            {
                return await _context.Outfits.ToListAsync();
            }

            public async Task<Outfit> Get(int id)
            {
                var outfit = await _context.Outfits.FindAsync(id);
                return outfit;
            }

            public async Task<Outfit> Add(Outfit outfit)
            {
                _context.Outfits.Add(outfit);
                await _context.SaveChangesAsync();
                return outfit;
            }

            public async Task<Outfit> Update(Outfit outfit)
            {
                _context.Entry(outfit).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return outfit;
            }

            public async Task<Outfit> Delete(int id)
            {
                var outfit = await _context.Outfits.FindAsync(id);
                _context.Outfits.Remove(outfit);
                await _context.SaveChangesAsync();
                return outfit;
            }
        }
    }
}
