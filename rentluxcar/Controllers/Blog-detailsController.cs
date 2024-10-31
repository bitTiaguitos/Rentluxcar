using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rentluxcar.Controllers
{
	public class Blog_detailsController : Controller
	{
		// GET: Blog_detailsController
		public ActionResult Blogdetails()
		{
			return View();
		}

		// GET: Blog_detailsController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Blog_detailsController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Blog_detailsController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Blog_detailsController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Blog_detailsController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Blog_detailsController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Blog_detailsController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
