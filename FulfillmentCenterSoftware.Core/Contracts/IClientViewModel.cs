using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models;

namespace FulfillmentCenterSoftware.Core.Contracts
{
 public interface IClientViewModel
    {
        public Client Client { get; set; }
    }
}
