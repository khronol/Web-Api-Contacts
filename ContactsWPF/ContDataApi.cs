using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ContactsWPF
{
    public class ContDataApi
    {
        private HttpClient HttpClient { get; set; }
        public ContDataApi()
        {
            HttpClient = new HttpClient();
        }

        public void AddContact(Contacts contact)
        {
            string url = @"https://localhost:44371/api/values";

            var r = HttpClient.PostAsync(
                requestUri: url,
                content: new StringContent(JsonConvert.SerializeObject(contact), Encoding.UTF8,
                mediaType: "application/json")
                ).Result;
        }
        public IEnumerable<Contacts> GetContacts()
        {
            string url = @"https://localhost:44371/api/values";

            string json = HttpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<IEnumerable<Contacts>>(json);
        }
    }
}
