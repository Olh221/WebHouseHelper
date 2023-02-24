﻿using Microsoft.AspNetCore.Identity;

namespace WebHouseHelper.Data
{
    public class AverageUser : IdentityUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
