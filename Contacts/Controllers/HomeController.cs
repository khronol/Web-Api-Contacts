using Contacts.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Contacts.Models;
using Contacts.DataContext;
using System.Linq;

namespace Contacts.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactsData contactsData;
        public HomeController(IContactsData ContactsData)
        {
            this.contactsData = ContactsData;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.Contacts = contactsData.GetContacts();
            return View();
        }
        [AllowAnonymous]
        public IActionResult Info()
        {
            
            return View();
        }
        [Authorize(Roles = "user, admin")]
        public IActionResult Editor()
        {
            ViewBag.Contacts = contactsData.GetContacts();
            return View();
        }
        [HttpPost]
        public IActionResult GetData(string surname, string name, string otch, string phone, string address, string caption)
        {
            Kont temp = new Kont()
            {
                Surname = surname,
                MainName = name,
                Otch = otch,
                Phone = phone,
                Address = address,
                Caption = caption
            };

            contactsData.AddContact(temp);

            return Redirect("~/");
        }
        [Authorize(Roles = "admin")]
        public IActionResult DeleteData(string id)
        {
            id = id.Remove(0,id.IndexOf('-')+1);
            contactsData.RemoveContact(id);
            return Redirect("index");
        }
        public IActionResult updateData(string id, string surname, string name, string otch, string phone, string address, string caption)
        {
            id = id.Remove(0, id.IndexOf('-') + 1);
            contactsData.EditContact(id, surname, name, otch, phone, address, caption);

            return Redirect("~/");
        }
    }
}
