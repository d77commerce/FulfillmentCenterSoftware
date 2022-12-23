using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FulfillmentCenterSoftware.Models
{
    public class Product
    {
        [Key] public int Id { get; set; }
        [Required][MaxLength(50)] public string Name { get; set; } = null!;
        [Required] public int Quantity { get; set; }
        [Required][MaxLength(300)] public string Description { get; set; } = null!;
        [Required][MaxLength(50)] public string ShortDescription { get; set; } = null!;
        [Required][MaxLength(50)] public string ProductBarcode { get; set; } = null!;
        [MaxLength(50)] public string? ProductStorageBarcode { get; set; }
        [MaxLength(50)] public string? ProductCode { get; set; }
        [Required] public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))] public Producer Producer { get; set;}= null!;
        [Required] public int OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))] public Owner Owner { get; set; }= null!;
    }
}
