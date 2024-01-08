using Microsoft.AspNetCore.Mvc;
using ScannerDemo.Models;
using System.Diagnostics;

namespace ScannerDemo.Controllers {
	public class HomeController : Controller {
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger) {
			_logger = logger;
		}

		public IActionResult Index() {
			return View();
		}

		public IActionResult ScanResult(string scanResult) {
			if(string.IsNullOrWhiteSpace(scanResult)) {
				scanResult = "No Data";
			}
			var scanData = new ScanData {
				ScanResult = scanResult
			};
			return View(scanData);
		}
		public IActionResult Privacy() {
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}