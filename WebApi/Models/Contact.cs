using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Models
{
    public class Contact : IContact
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string MainName { get; set; }
        public string Otch { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Caption { get; set; }
    }
}
