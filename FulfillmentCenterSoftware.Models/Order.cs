using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Models.Enums;

namespace FulfillmentCenterSoftware.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required] public int OwnerId { get; set; }
        [Required] public int ProductId { get; set; }
        [Required] public int Quantity { get; set; }
        [Required] public Packaging Packaging { get; set; }
        [Required] public bool AddType { get; set; } = true;
        [Required] public bool AddPaper { get; set; } = false;
        [Required] public bool AddBubbleWraps { get; set; } = false;
        [Required] public OrderStatus Status { get; set; }
        [Required] public int TraysNo { get; set; }
        [Required] public string Instruction { get; set; } = null!;

    }
}
