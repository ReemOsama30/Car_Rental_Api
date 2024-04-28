﻿using Microsoft.AspNetCore.Identity;

namespace Car_Rental.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Rental>? rentals { set; get; }
        public ICollection<Payment>? payments { get; set; }
    }
}
