using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FulfillmentCenterSoftware.Infrastructure.Configuration
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{
		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.HasData(Clients());

		}

		private List<Client> Clients()
		{
			var clients = new List<Client>()
			{
				new Client()
				{
					Id = 1,
					CompanyName = "Click and Grab ltd",
					CompanyNo = "123456",
					VatNo = "GB122345",
					Description = "Test Company",
					Country = "UK",
					Town = "London",
					Street = "34 Oniks",
					AddressLine1 = "City centre",
					AddressLine2 = "Tower Bridge",
					Postcode = "EW23 3AS",
					Email = "test@test.co.uk",
					PhoneNo = "+44 3454642390",
					WebSite = "https//clickandgrab.co.uk"
				},
				new Client()
				{
					Id = 2,
					CompanyName = "Formo express ltd",
					CompanyNo = "9993456",
					VatNo = "GB999345",
					Description = "Test Company 2",
					Country = "UK",
					Town = "London",
					Street = "55 Ludvig",
					AddressLine1 = "City centre",
					AddressLine2 = "Tower Bridge",
					Postcode = "EW54 2AS",
					Email = "test2@test.co.uk",
					PhoneNo = "+44 7998390",
					WebSite = "https//formoexpress.co.uk"
				}
			};
			return clients;
		}
	}
}
/*
[Key] public int Id { get; set; }
[Required][MaxLength(100)] public string CompanyName { get; set; } = null!;
[Required][MaxLength(20)] public string CompanyNo { get; set; } = null!;
[Required][MaxLength(20)] public string? VatNo { get; set; }
[Required][MaxLength(100)] public string Description { get; set; } = null!;
[Required][MaxLength(100)] public string Country { get; set; } = null!;
[Required][MaxLength(100)] public string Town { get; set; } = null!;
[Required][MaxLength(100)] public string Street { get; set; } = null!;
[Required][MaxLength(100)] public string? AddressLine1 { get; set; }
[Required][MaxLength(100)] public string? AddressLine2 { get; set; }
[Required][MaxLength(10)] public string Postcode { get; set; } = null!;
[Required][MaxLength(100)] public string Email { get; set; } = null!;
[Required][MaxLength(100)] public string PhoneNo { get; set; } = null!;
[MaxLength(100)] public string? WebSite { get; set; }

public virtual IEnumerable<Product>? Products { get; set; } = new List<Product>();
*/

