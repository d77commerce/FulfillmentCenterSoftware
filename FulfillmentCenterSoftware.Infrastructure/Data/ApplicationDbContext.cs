using FulfillmentCenterSoftware.Infrastructure.Configuration;
using FulfillmentCenterSoftware.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FulfillmentCenterSoftware.Infrastructure.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new ProductConfiguration());
			builder.ApplyConfiguration(new ClientConfiguration());
			builder.ApplyConfiguration(new ProducerConfiguration());
			builder.ApplyConfiguration(new StoragePlaceConfiguration());
			base.OnModelCreating(builder);
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Producer> Producers { get; set; }
		public DbSet<StoragePlace> StoragePlaces { get; set; }
	}
}