using Contacts.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Contacts.Models;

namespace Contacts.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactsData contactsData;
        public HomeController(IContactsData ContactsData)
        {
            this.contactsData = ContactsData;
        }
        public IActionResult Index(IContactsData data)
        {
            return View(contactsData.GetContacts());
        }

        public IActionResult Info()
        {
            return View();
        }
        public IActionResult Editor()
        {
            ViewBag.Contacts = contactsData.GetContacts();
            return View();
        }
        [HttpGet]
        [Authorize]
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
        //public IActionResult DeleteData(string id)
        //{
        //    id = id.Remove(0, id.Length - 1);
        //    db.Contacts.Remove(db.Contacts.Find(int.Parse(id)));
        //    db.SaveChanges();
        //    return Redirect("~/");
        //}
        //public IActionResult UpdateData(string id, string surname, string name, string otch, string phone, string address, string caption)
        //{
        //    id = id.Remove(0, id.Length - 1);
        //    db.Contacts.Update(
        //        new Contacts()
        //        {
        //            Id = int.Parse(id),
        //            Surname = surname,
        //            MainName = name,
        //            Otch = otch,
        //            Phone = phone,
        //            Address = address,
        //            Caption = caption
        //        });
        //    db.SaveChanges();
        //    return Redirect("~/");
        //}
    }
}
