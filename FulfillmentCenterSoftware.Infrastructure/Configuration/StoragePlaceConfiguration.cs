using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models;
using FulfillmentCenterSoftware.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FulfillmentCenterSoftware.Infrastructure.Configuration
{
	public class StoragePlaceConfiguration : IEntityTypeConfiguration<StoragePlace>
	{
		public void Configure(EntityTypeBuilder<StoragePlace> builder)
		{
			builder.HasData(StoragePlaces());
		}

		private List<StoragePlace> StoragePlaces()
		{
			var storegePlaces = new List<StoragePlace>()
			{
				new StoragePlace
				{
					Id = 1,
					RackId = 1,
					Color = Color.Red,
					Zone = Zone.A
				},
				new StoragePlace
				{
					Id = 2,
					RackId = 1,
					Color =Color.Blue,
					Zone = Zone.B
				}
			};
			return storegePlaces;
		}
	}
}
