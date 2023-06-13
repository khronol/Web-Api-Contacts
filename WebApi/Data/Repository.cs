using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Data
{
    public class Repository
    {
        static List<IContact> data;
        static Repository()
        {
            data = new List<IContact>()
            {
               new Contact(){Id=1,Surname = "Gladkov", MainName = "Mikhail", Otch = "Gwatemala", Phone="+41204913232",Address="KoloKolo 42" ,Caption = ""},
               new Contact(){Id=2,Surname = "DaraDa", MainName = "Ivan", Otch = "Pushkinovich", Phone="+9981178742",Address="Ladoga 66" ,Caption = "Tax Manager"},
               new Contact(){Id=3,Surname = "Konyakin", MainName = "Adasf", Otch = "JesusChrist", Phone="+112321958",Address="Patoka 13" ,Caption = "Boec"},
               new Contact(){Id=4,Surname = "LoLoLoev", MainName = "Servet", Otch = "MegaLodonovich", Phone="+7994821",Address="Zinedina Zidana 55" ,Caption = "BrainForcer"}
            };
        }

        public static void AddCar(IContact contact)
        {
            contact.Id = data.Count;
            data.Add(contact);
        }

        public static IEnumerable<IContact> GetContacts() => data;

        public static IContact GetContactById(int Id) => Id >= 0 && Id < data.Count ? data[Id] : NullContact.Create();
        public static IEnumerable<IContact> GetContactRange(int pos, int count)
            => data.Where(contact => contact.Id >= pos && contact.Id < pos + count);
    }
}
