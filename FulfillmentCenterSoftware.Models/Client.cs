using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FulfillmentCenterSoftware.Models
{
   public class Client
    {
        [Key] public int Id { get; set; }
        [Required][MaxLength(100)] public string CompanyName { get; set; } = null!;
        [Required][MaxLength(20)] public string CompanyNo { get; set; } = null!;
        [Required] [MaxLength(20)] public string? VatNo { get; set; }
        [Required][MaxLength(100)] public string Description { get; set; } = null!;
        [Required][MaxLength(100)] public string Country { get; set; } = null!;
        [Required][MaxLength(100)] public string Town { get; set; } = null!;
        [Required] [MaxLength(100)] public string Street { get; set; } = null!;
        [Required] [MaxLength(100)] public string? AddressLine1 { get; set; }
        [Required] [MaxLength(100)] public string? AddressLine2 { get; set; }
        [Required] [MaxLength(10)] public string Postcode { get; set; } = null!;
        [Required][MaxLength(100)] public string Email { get; set; } = null!;
        [Required][MaxLength(100)] public string PhoneNo { get; set; } = null!;
        [MaxLength(100)] public string? WebSite { get; set; } 

		public virtual IEnumerable<Product>? Products { get; set; } = new List<Product>();

    }
}
