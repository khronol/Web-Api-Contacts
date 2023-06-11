using Contacts.DataContext;
using Contacts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Contacts.Data
{
    public static class InitDb
    {
        public static void Initialize(ContactsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contacts.Any()) return;

            var sections = new List<Kont>()
            {
                new Kont(){Id=1,Surname = "Gladkov", MainName = "Mikhail", Otch = "Gwatemala", Phone="+41204913232",Address="KoloKolo 42" ,Caption = ""}
            };
            using (var trans = context.Database.BeginTransaction())
            {
                foreach (var section in sections)
                {
                    context.Contacts.Add(section);
                }

                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Contacts] ON");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Contacts] OFF");
                trans.Commit();
            }
        }
    }
}
