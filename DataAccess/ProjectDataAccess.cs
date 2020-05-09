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
        public interface IProjectsService
        {
            Task<List<Project>> Get();
            Task<Project> Get(int id);
            Task<Project> Add(Project project);
            Task<Project> Update(Project project);
            Task<Project> Delete(int id);
        }
        public class ProjectsService : IProjectsService
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
                var project = await _context.Projects.FindAsync(id);
                return project;
            }

            public async Task<Project> Add(Project project)
            {
                _context.Projects.Add(project);
                await _context.SaveChangesAsync();
                return project;
            }

            public async Task<Project> Update(Project project)
            {
                _context.Entry(project).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return project;
            }

            public async Task<Project> Delete(int id)
            {
                var project = await _context.Projects.FindAsync(id);
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
                return project;
            }
        }
    }
}
