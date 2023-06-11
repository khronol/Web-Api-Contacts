using Contacts.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacts.ContextFolder
{
    public class DataContext : DbContext
    {
        public DbSet<Kont> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (
                @"Server=(localdb)\MSSQLLocalDB;
                  DataBase=_EntityCoreContacts;
                  Trusted_Connection=true;"
);

        }
    }
}
