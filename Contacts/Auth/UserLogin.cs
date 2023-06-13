using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Contacts.Auth
{
    public class UserLogin
    {


        [Required, MaxLength(256)]
        public string LoginProp { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
