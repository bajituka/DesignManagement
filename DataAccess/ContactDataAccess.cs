using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignManagement.DataAccess
{
    public class ContactDataAccessLayer
    {
        public interface IContactService
        {
            Task<List<Contact>> Get();
            Task<Contact> Get(int id);
            Task<Contact> Add(Contact project);
            Task<Contact> Update(Contact project);
            Task<Contact> Delete(int id);
        }
        public class ContactsService : IContactService
        {
            private readonly DesignMgmtContext _context;

            public ContactsService(DesignMgmtContext context)
            {
                _context = context;
            }
            public async Task<List<Contact>> Get()
            {
                return await _context.Contacts.ToListAsync();
            }

            public async Task<Contact> Get(int id)
            {
                var project = await _context.Contacts.FindAsync(id);
                return project;
            }

            public async Task<Contact> Add(Contact project)
            {
                _context.Contacts.Add(project);
                await _context.SaveChangesAsync();
                return project;
            }

            public async Task<Contact> Update(Contact project)
            {
                _context.Entry(project).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return project;
            }

            public async Task<Contact> Delete(int id)
            {
                var project = await _context.Contacts.FindAsync(id);
                _context.Contacts.Remove(project);
                await _context.SaveChangesAsync();
                return project;
            }
        }
    }
}
