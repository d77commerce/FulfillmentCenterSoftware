using FulfillmentCenterSoftware.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FulfillmentCenterSoftware.Core.Models;
using FulfillmentCenterSoftware.Infrastructure.Common;
using FulfillmentCenterSoftware.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FulfillmentCenterSoftware.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Add()
        {
            IEnumerable<ProductViewModel> products = _unitOfWork.Product.GetAll().Select(p => new ProductViewModel()
            {
                Product = new Product()
                {
                    Name = p.Name,
                    Description = p.Description,
                    Kg = p.Kg,
                    Client = p.Client,
                    ClientId = p.ClientId
                },
                ClienItems = _unitOfWork.Client.GetAll().
                    Where(cli => cli.Id == p.ClientId).
                    Select(c => new SelectListItem
                    {
                        Text = c.CompanyName,
                        Value = c.Id.ToString()
                    })
            });
            return View(products);
        }


        public IActionResult ProductsByClient(int companyId)
        {

            IEnumerable<ProductViewModel> productsById = _unitOfWork.Product.GetAll().
                Where(prod => prod.ClientId == companyId).
                Select(p => new ProductViewModel()
                {
                    Product = new Product()
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Kg = p.Kg,
                        Client = p.Client,
                        ClientId = p.ClientId
                    },
                    ClienItems = _unitOfWork.Client.GetAll().
                    Where(cli => cli.Id == p.ClientId).
                    Select(c => new SelectListItem
                    {
                        Text = c.CompanyName,
                        Value = c.Id.ToString()
                    })
                });

            return View(productsById);
        }

        /*
        [HttpPost]
        public IActionResult ProductByClient(int companyId, ProductViewModel _product)
        {


            if (_product.Product.Id == 0)
            {
                _unitOfWork.Product.Add(_product.Product);
            }
            else
            {
                _unitOfWork.Product.Update(_product.Product);
            }

            return RedirectToAction(nameof(ProductByClient));
        }*/

        public IActionResult Clients()
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
            return View(clients);
        }

        public IActionResult AddNewProduct(int clientId)
        {
            if (clientId !=0)
            {
                Client client = _unitOfWork.Client.Get(clientId);
                ViewBag.companyName = client.CompanyName;
                return View();
            }
            ViewBag.companyName = "client.CompanyName";
            return View();
        }
    }
}