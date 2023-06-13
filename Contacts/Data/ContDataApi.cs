using Contacts.Interfaces;
using Contacts.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Contacts.Data
{
    public class CarDataApi : IContactsData
    {
        private HttpClient HttpClient { get; set; }

        public CarDataApi()
        {
            HttpClient = new HttpClient();
        }



        IEnumerable<Models.Kont> IContactsData.GetContacts()
        {
            string url = @"https://localhost:44371/api/values";

            string json = HttpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<IEnumerable<Kont>>(json);
        }

        public void AddContact(Models.Kont contact)
        {
            string url = @"https://localhost:44371/api/values";

            var r = HttpClient.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(contact), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }

        public void RemoveContact(string id)
        {
            throw new System.NotImplementedException();
        }

        public void EditContact(string id, string surname, string name, string otch, string phone, string address, string caption)
        {
            throw new System.NotImplementedException();
        }
    }
}
