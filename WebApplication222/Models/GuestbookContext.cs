using Microsoft.EntityFrameworkCore;

namespace WebApplication222.Models
{
    public class GuestbookContext : DbContext
    {
        public DbSet<GuestbookEntry> Entries { get; set; }
        public GuestbookContext()
        {
            Database.EnsureCreated();// comment when Migration
        }
        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {
            op.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDb2024.06.11xxxxxx;Trusted_Connection=True;");
        }

    }
}
