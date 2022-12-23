using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models.Enums;

namespace FulfillmentCenterSoftware.Models
{
    public class StoragePlace
    {
        [Key] public int Id { get; set; }
        [Required] public Color Color { get; set; }
        [Required] public Zone Zone { get; set; }
    }
}
