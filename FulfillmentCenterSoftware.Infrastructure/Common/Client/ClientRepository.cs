using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Infrastructure.Data;
using FulfillmentCenterSoftware.Models;

namespace FulfillmentCenterSoftware.Infrastructure.Common.Client
{
    public class ClientRepository : Repository<Models.Client>, IClientRepository
    {
        private ApplicationDbContext _context;
        public ClientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.Client client)
        {
            var obj = _context.Clients.FirstOrDefault(c => c.Id == client.Id);
            if (obj != null)
            {
                obj.Id=client.Id;
                obj.CompanyName = client.CompanyName;
                obj.CompanyNo = client.CompanyNo;
                obj.Description = client.Description;
                obj.Country = client.Country;
                obj.Town = client.Town;
                obj.Street = client.Street;
                obj.AddressLine1 = client.AddressLine1;
                obj.AddressLine2 = client.AddressLine2;
                obj.Email = client.Email;
                obj.Postcode = client.Postcode;
                obj.VatNo = client.VatNo;
                obj.WebSite = client.WebSite;
                obj.PhoneNo = client.PhoneNo;
            }
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
