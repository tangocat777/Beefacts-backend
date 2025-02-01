using BeeFacts.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeFacts.Data
{
    public class BeeFactContext : DbContext
    {
        public BeeFactContext(DbContextOptions<BeeFactContext> options) : base(options)
        {

        }

        DbSet<BeeFact> BeeFacts { get; set; }
    }
}
