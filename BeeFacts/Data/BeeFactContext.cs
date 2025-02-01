using BeeFacts.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace BeeFacts.Data
{
    public class BeeFactContext : DbContext
    {
        public BeeFactContext(DbContextOptions<BeeFactContext> options) : base(options)
        {

        }

        public DbSet<BeeFact> BeeFacts { get; set; }
    }
}
