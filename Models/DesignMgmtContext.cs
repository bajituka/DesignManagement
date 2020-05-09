using Microsoft.EntityFrameworkCore;

namespace DesignManagement.Models
{
    public class DesignMgmtContext : DbContext
    {
        public DesignMgmtContext(DbContextOptions<DesignMgmtContext> options)
           : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
