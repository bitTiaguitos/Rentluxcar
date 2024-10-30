using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rentluxcar.Controllers
{
	public class Admin_indexController : Controller
	{
		// GET: Admin_indexController
		public ActionResult Index()
		{
			return View();
		}

		// GET: Admin_indexController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Admin_indexController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Admin_indexController/Create
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

		// GET: Admin_indexController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Admin_indexController/Edit/5
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

		// GET: Admin_indexController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Admin_indexController/Delete/5
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
