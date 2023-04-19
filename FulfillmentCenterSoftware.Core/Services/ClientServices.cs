using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FulfillmentCenterSoftware.Core.Models;
using FulfillmentCenterSoftware.Infrastructure.Common;
using FulfillmentCenterSoftware.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FulfillmentCenterSoftware.Core.Services
{
    public class ClientServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Client _client;
        public ClientServices(IUnitOfWork unitOfWork,Client client)
        {
            _unitOfWork=unitOfWork;
            _client=client;
        }
        public IEnumerable<ClientViewModel> ClientViewModelService()
        {
            IEnumerable<ClientViewModel> clients = _unitOfWork.Client.GetAll().Select(c => new ClientViewModel()
            {
                Client = new Client()
                {
                    CompanyName = c.CompanyName,
                    CompanyNo = c.CompanyNo,
                    Id = c.Id,

                },
                ProductsList = _unitOfWork.Product.GetAll().Where(pro => pro.ClientId == c.Id).Select(p => new SelectListItem
                {

                    Text = p.Name,
                    Value = p.Id.ToString()
                })
            });
            return clients;
        }
    }
}
