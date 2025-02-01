using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingApp.MVVM.Models
{
    class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? PostalCode { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string DOB { get; set; }
    }
}
