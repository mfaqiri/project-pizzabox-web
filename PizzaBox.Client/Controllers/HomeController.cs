using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public HomeController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
         var OrderViewModel = new OrderViewModel();
         OrderViewModel.Populate(_unitOfWork);
         var view = View("index", OrderViewModel);

         return View("order", OrderViewModel);
        }


    }
}
