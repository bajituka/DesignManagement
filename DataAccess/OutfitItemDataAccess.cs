using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignManagement.DataAccess
{
    public class OutfitItemDataAccessLayer
    {
        public interface IOutfitItemService
        {
            Task<List<OutfitItem>> Get();
            Task<OutfitItem> Get(int id);
            Task<OutfitItem> Add(OutfitItem outfitItem);
            Task<OutfitItem> Update(OutfitItem outfitItem);
            Task<OutfitItem> Delete(int id);
        }
        public class OutfitItemService : IOutfitItemService
        {
            private readonly DesignMgmtContext _context;

            public OutfitItemService(DesignMgmtContext context)
            {
                _context = context;
            }
            public async Task<List<OutfitItem>> Get()
            {
                return await _context.OutfitItems.ToListAsync();
            }

            public async Task<OutfitItem> Get(int id)
            {
                var outfitItem = await _context.OutfitItems.FindAsync(id);
                return outfitItem;
            }

            public async Task<OutfitItem> Add(OutfitItem outfitItem)
            {
                _context.OutfitItems.Add(outfitItem);
                await _context.SaveChangesAsync();
                return outfitItem;
            }

            public async Task<OutfitItem> Update(OutfitItem outfitItem)
            {
                _context.Entry(outfitItem).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return outfitItem;
            }

            public async Task<OutfitItem> Delete(int id)
            {
                var outfitItem = await _context.OutfitItems.FindAsync(id);
                _context.OutfitItems.Remove(outfitItem);
                await _context.SaveChangesAsync();
                return outfitItem;
            }
        }
    }
}
