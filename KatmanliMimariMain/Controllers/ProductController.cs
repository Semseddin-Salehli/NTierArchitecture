using BusinessLayer.Abstract;
using EntityLayer.Conrete;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimariMain.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult GetAll() 
        {
            var result = _productService.GetAll();

            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            _productService.Add(product);
            return RedirectToAction("Index");
        }
    }
}
