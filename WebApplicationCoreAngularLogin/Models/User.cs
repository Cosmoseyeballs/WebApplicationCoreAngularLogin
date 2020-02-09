using System;
using System.Collections.Generic;

namespace WebApplicationCoreAngularLogin.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
