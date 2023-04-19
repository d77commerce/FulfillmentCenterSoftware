using FulfillmentCenterSoftware.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Infrastructure.Common.Client;
using FulfillmentCenterSoftware.Infrastructure.Common.Product;

namespace FulfillmentCenterSoftware.Infrastructure.Common
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context=context;
            Product = new ProductRepository(context);
            Client=new ClientRepository(context);
        }

        public IProductRepository Product  { get; private set; }
        public IClientRepository Client { get; private set; }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
   
}
