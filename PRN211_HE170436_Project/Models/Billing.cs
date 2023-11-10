using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_HE170436_Project.Models
{
    public class Billing
    {
        [Key]
        public int BillingId { get; set; }
        [StringLength(150)]
        public string? BillingFistName { get; set; }
        [StringLength(150)]
        public string? BillingLastName { get; set; }
        [StringLength(150)]
        public string? BillingEmail { get; set; }
        [StringLength(15)]
        public string? BillingPhone { get; set; }
        [StringLength(50)]
        public string? BillingAddress1 { get; set; }
        [StringLength(50)]
        public string? BillingAddress2 { get; set; }
        [StringLength(50)]
        public string? BillingCountry { get; set; }
        [StringLength(50)]
        public string? BillingCity { get; set; }
        [StringLength(50)]
        public string? BillingState { get; set; }
        [StringLength(10)]
        public string? BillingPostalCode { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
