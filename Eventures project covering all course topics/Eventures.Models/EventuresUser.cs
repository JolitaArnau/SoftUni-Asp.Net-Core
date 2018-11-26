namespace Eventures.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class EventuresUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UniqueCitizenNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}