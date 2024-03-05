using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
	public class AllJobsController : Controller
	{
		// GET: AllJobsController - returns all jobs
		public ActionResult AllJobs()
		{
			return View();
		}
	}
}
