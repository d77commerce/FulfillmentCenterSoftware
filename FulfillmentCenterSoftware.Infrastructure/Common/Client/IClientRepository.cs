using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FulfillmentCenterSoftware.Infrastructure.Common.Client
{
  public interface IClientRepository:IRepository<Models.Client>
    {
        void Update (Models.Client client);
    }
}
