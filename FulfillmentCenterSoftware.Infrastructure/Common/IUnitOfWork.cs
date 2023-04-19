using FulfillmentCenterSoftware.Infrastructure.Common.Client;
using FulfillmentCenterSoftware.Infrastructure.Common.Product;

namespace FulfillmentCenterSoftware.Infrastructure.Common
{
    public interface IUnitOfWork
    {
        public IProductRepository  Product { get;  }
        public IClientRepository Client { get; }
        void Save();
    }
}
