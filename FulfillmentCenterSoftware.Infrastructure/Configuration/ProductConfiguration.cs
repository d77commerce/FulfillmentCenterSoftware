using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FulfillmentCenterSoftware.Infrastructure.Configuration
{

		public class ProductConfiguration : IEntityTypeConfiguration<Product>
		{
			public void Configure(EntityTypeBuilder<Product> builder)
			{
				builder.HasData(Products());
			}

			private List<Product> Products()
			{
				var products = new List<Product>()
				{
					new Product
					{
						Id = 1,
						Name = "Test Product1",
						Kg = 3.358,
						LengthCm = 35,
						HeightCm = 21,
						WidthCm = 10,
						Price = 2.10M,
						Price10 = 2.015M,
						PiecesPerBox = 12,
						BoxesPerPallet = 65,
						Description = "long description ! ! !",
						ShortDescription = "short description ! ! !",
						ProductBarcode	= "1234567891",
						ProductStorageBarcode = "c&g100001",
						ProductCode = "c&g001",
						ProducerId = 1,
						PicUrl = "http://clickandgrab.trakia.co.uk/wp-content/uploads/2020/05/clickandgrab.co_.uk-poster-2-2048x1006.jpg",
						ClientId = 1,
						StoragePlaceId = 1
					},
					new Product
					{
						Id = 2,
						Name = "Test Product2",
						Kg = 4.358,
						LengthCm = 45,
						HeightCm = 11,
						WidthCm = 10,
						Price = 3.10M,
						Price10 =3.015M,
						PiecesPerBox = 18,
						BoxesPerPallet = 65,
						Description = "long description ! ! !",
						ShortDescription = "short description ! ! !",
						ProductBarcode  = "9234567891",
						ProductStorageBarcode = "c&g100002",
						ProductCode = "c&g002",
						ProducerId = 2,
						PicUrl = "http://clickandgrab.trakia.co.uk/wp-content/uploads/2020/05/clickandgrab.co_.uk-poster-2-2048x1006.jpg",
						ClientId = 2,
						StoragePlaceId = 2
					}
				};
				return products;
			}
		}
	}
/*
        [Key] public int Id { get; set; }
        [Required][MaxLength(50)] public string Name { get; set; } = null!;
        [Required] public int Quantity { get; set; }
        [Required] public double Kg { get; set; }
        [Required] public int? LengthCm { get; set; }
        [Required] public int? HeightCm { get; set; }
        [Required] public int? WidthCm { get; set; }
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
*/

