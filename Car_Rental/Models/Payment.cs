using Car_Rental.Enums;
using Car_Rental.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental.Models
{
    public class Payment : ISoftDeletable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.BankTransfer;
        public decimal Amount { get; set; }

        [ForeignKey("customer")]
        public string Customer_Id { set; get; }
        public ApplicationUser customer { set; get; }
        public bool IsDeleted { get; set; } = false;
        public Maintenance? Maintenance { get; set; }

    }
}
