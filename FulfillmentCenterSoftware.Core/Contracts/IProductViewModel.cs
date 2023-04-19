using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models;

namespace FulfillmentCenterSoftware.Core.Contracts
{
    public interface IProductViewModel
    {
        public Product Product { get; set; }
    }
}
