using Contacts.DataContext;
using Contacts.Interfaces;
using Contacts.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void RemoveContact(string id)
        {
            context.Remove(context.Contacts.Find(int.Parse(id)));
            context.SaveChanges();

        }
        public void EditContact(string id,string surname, string name, string otch, string phone, string address, string caption)
        {
            context.Contacts.Update(
                new Kont()
                {
                    Id = int.Parse(id),
                    Surname = surname,
                    MainName = name,
                    Otch = otch,
                    Phone = phone,
                    Address = address,
                    Caption = caption
                });
            context.SaveChanges();
        }
    }
}
