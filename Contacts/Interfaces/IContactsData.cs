using Contacts.Models;
using System.Collections.Generic;

namespace Contacts.Interfaces
{
    public interface IContactsData
    {
        IEnumerable<Kont> GetContacts();
        void AddContact(Kont contact);
        void RemoveContact(string id);
        void EditContact(string id, string surname, string name, string otch, string phone, string address, string caption);
    }
}
