using Microsoft.AspNetCore.Mvc;
using MoneyManager.Application.Interfaces;
using MoneyManager.WebUI.Models;
using System.Diagnostics;

namespace MoneyManager.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountBankService _accountBankService;
        public HomeController(ILogger<HomeController> logger, IAccountBankService accountBankService)
        {
            _logger = logger;
            _accountBankService = accountBankService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            return View(await _accountBankService.GetAll());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}