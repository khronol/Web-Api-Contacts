using Contacts.DataContext;
using Contacts.Interfaces;
using Contacts.Models;
using System.Collections.Generic;

namespace Contacts.Data
{
    public class ContactsData : IContactsData
    {
        private readonly ContactsDbContext context;

        public ContactsData(ContactsDbContext context)
        {
            this.context = context;
        }

        public void AddContact(Kont contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public IEnumerable<Kont> GetContacts()
        {
            return this.context.Contacts;
        }
    }
}
