using Car_Rental.Enums;
using Car_Rental.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.SqlServer.Server;

namespace Car_Rental.Models
{
    public class ApplicationUser : IdentityUser, ISoftDeletable
    {

        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public ICollection<Rental>? rentals { set; get; }
        public ICollection<Payment>? payments { get; set; }
        public List<Comments>? comments { get; set; }
        public bool IsDeleted { get; set; } = false;

        public UserType userType { get; set; } = UserType.Customer;



    }
}
