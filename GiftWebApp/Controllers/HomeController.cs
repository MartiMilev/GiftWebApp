using GiftWebApp.Contracts;
using GiftWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GiftWebApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly IEmployyeService employyeService;

        public HomeController(IEmployyeService employyeService)
        {
            this.employyeService = employyeService;
        }
        public async Task<IActionResult> Index()
		{
			var users = await employyeService.AllEmployyes();
			return View(users);
		}

	}
}