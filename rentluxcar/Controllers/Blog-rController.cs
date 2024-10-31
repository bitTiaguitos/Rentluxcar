using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rentluxcar.Controllers
{
	public class Blog_rController : Controller
	{
		// GET: Blog_rController
		public ActionResult Blogr()
		{
			return View();
		}

		// GET: Blog_rController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Blog_rController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Blog_rController/Create
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

		// GET: Blog_rController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Blog_rController/Edit/5
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

		// GET: Blog_rController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Blog_rController/Delete/5
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
