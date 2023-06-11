using Contacts.Models;
using System.Collections.Generic;

namespace Contacts.Interfaces
{
    public interface IContactsData
    {
        IEnumerable<Kont> GetContacts();
        void AddContact(Kont contact);
    }
}
