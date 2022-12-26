using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> nums = new List<DogViewModel>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateNum(DogViewModel dogViewModel)
        {
            //return View("Index");
            nums.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            return View(nums);
        }
    }
}
