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
        [Required] public decimal Kg { get; set; }
        [Required] public decimal Length { get; set; }
        [Required] public decimal Height { get; set; }
        [Required] public decimal Width { get; set; }
        [Required] public decimal Price { get; set; }
        public decimal? Price10 { get; set; }
		public int? PiecesPerBox { get; set; }
        public int? BoxesPerPallet { get; set; }
        [Required][MaxLength(300)] public string Description { get; set; } = null!;
        [Required][MaxLength(50)] public string ShortDescription { get; set; } = null!;
        [Required][MaxLength(50)] public string ProductBarcode { get; set; } = null!;
        [MaxLength(50)] public string? ProductStorageBarcode { get; set; }
        [MaxLength(50)] public string? ProductCode { get; set; }
        [Required] public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))] public Producer Producer { get; set;}= null!;
        public string? PicUrl { get; set; }
		[Required] public int OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))] public Client Client { get; set; }= null!;
        [Required] public int StoragePlaceId { get; set; }
        [ForeignKey(nameof(StoragePlaceId))] public StoragePlace StoragePlace { get; set; }
    }
}
