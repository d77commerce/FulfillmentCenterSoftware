using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FulfillmentCenterSoftware.Infrastructure.Configuration
{
	public class ProducerConfiguration: IEntityTypeConfiguration<Producer>
	{
		public void Configure(EntityTypeBuilder<Producer> builder)
		{
			builder.HasData(Producers());
		}

		private List<Producer> Producers()
		{
			var producers = new List<Producer>()
			{
				new Producer()
				{
					Id = 1,
					Name = "Click & Grab Producing ltd",
					Description = "Test Producer"
				},
				new Producer()
				{
					Id = 2,
					Name = "Formo Commerce ltd",
					Description = "Test producer 2"
				}
			};
			return producers;
		}
	}
}
