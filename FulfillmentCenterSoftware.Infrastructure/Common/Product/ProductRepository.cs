using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Infrastructure.Data;
using FulfillmentCenterSoftware.Models;

namespace FulfillmentCenterSoftware.Infrastructure.Common.Product
{
    internal class ProductRepository : Repository<Models.Product>, IProductRepository
    {
        private ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Models.Product product)
        {
            var objDb = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (objDb != null)
            {
                objDb.Id=product.Id;
                objDb.Name = product.Name;
                objDb.Quantity = product.Quantity;
                objDb.Kg = product.Kg;
                objDb.LengthCm = product.LengthCm;
                objDb.HeightCm = product.HeightCm;
                objDb.WidthCm = product.WidthCm;
                objDb.Price = product.Price;
                objDb.Price10 = product.Price10;
                objDb.PiecesPerBox = product.PiecesPerBox;
                objDb.BoxesPerPallet = product.BoxesPerPallet;
                objDb.Description = product.Description;
                objDb.ShortDescription = product.ShortDescription;
                objDb.ProductBarcode = product.ProductBarcode;
                objDb.ProductStorageBarcode = product.ProductStorageBarcode;
                objDb.ProductCode = product.ProductCode;
                if (objDb.PicUrl != null)
                {
                    objDb.PicUrl=product.PicUrl;
                }
                objDb.ProducerId = product.ProducerId;
                objDb.ClientId = product.ClientId;
                objDb.Client=product.Client;
                objDb.StoragePlaceId = product.StoragePlaceId;


            }
        }
    }
}

/*

[Required] public int ProducerId { get; set; }
[ForeignKey(nameof(ProducerId))] public Producer Producer { get; set; } = null!;
public string? PicUrl { get; set; }
[Required] public int ClientId { get; set; }
[ForeignKey(nameof(ClientId))] public Client Client { get; set; } = null!;
[Required] public int StoragePlaceId { get; set; }
[ForeignKey(nameof(StoragePlaceId))] public StoragePlace StoragePlace { get; set; }
*/

