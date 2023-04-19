using FulfillmentCenterSoftware.Core.Contracts;
using FulfillmentCenterSoftware.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FulfillmentCenterSoftware.Core.Models
{
    public class ClientViewModel :IClientViewModel
    {
        public Client Client { get; set; }
        public IEnumerable<SelectListItem> ProductsList { get; set; }
    }
}
