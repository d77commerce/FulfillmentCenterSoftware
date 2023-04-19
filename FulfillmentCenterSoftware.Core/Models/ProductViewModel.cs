using FulfillmentCenterSoftware.Core.Contracts;
using FulfillmentCenterSoftware.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FulfillmentCenterSoftware.Core.Models
{
    public class ProductViewModel : IProductViewModel
    {
        public Product Product { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ProducerItems { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ClienItems { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> StoragePlaceItems { get; set; }
    }
}
