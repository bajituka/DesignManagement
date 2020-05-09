using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignManagement.DataAccess
{
    public class ProjectDataAccessLayer
    {
        public interface IProjectService
        {
            Task<List<Project>> Get();
            Task<Project> Get(int id);
            Task<Project> Add(Project contact);
            Task<Project> Update(Project contact);
            Task<Project> Delete(int id);
        }
        public class ProjectsService : IProjectService
        {
            private readonly DesignMgmtContext _context;

            public ProjectsService(DesignMgmtContext context)
            {
                _context = context;
            }
            public async Task<List<Project>> Get()
            {
                return await _context.Projects.ToListAsync();
            }

            public async Task<Project> Get(int id)
            {
                var contact = await _context.Projects.FindAsync(id);
                return contact;
            }

            public async Task<Project> Add(Project contact)
            {
                _context.Projects.Add(contact);
                await _context.SaveChangesAsync();
                return contact;
            }

            public async Task<Project> Update(Project contact)
            {
                _context.Entry(contact).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return contact;
            }

            public async Task<Project> Delete(int id)
            {
                var contact = await _context.Projects.FindAsync(id);
                _context.Projects.Remove(contact);
                await _context.SaveChangesAsync();
                return contact;
            }
        }
    }
}
