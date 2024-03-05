using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class JobDetailsController : Controller
	{
		public IActionResult JobDetails()
		{
			return View();
		}
	}
}
