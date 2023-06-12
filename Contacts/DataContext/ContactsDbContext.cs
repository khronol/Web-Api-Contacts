using Contacts.Auth;
using Contacts.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contacts.DataContext
{
    public class ContactsDbContext : IdentityDbContext<User>
    {
        public ContactsDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Kont> Contacts { get; set; }
    }
}
