using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class ResumeController : Controller
	{
		public IActionResult Resume()
		{
			return View();
		}
	}
}
