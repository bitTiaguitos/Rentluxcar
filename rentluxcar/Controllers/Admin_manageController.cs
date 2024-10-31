using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rentluxcar.Controllers
{
	public class Admin_manageController : Controller
	{
		// GET: Admin_manageController
		public ActionResult Adminmanage()
		{
			return View();
		}

		// GET: Admin_manageController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Admin_manageController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Admin_manageController/Create
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

		// GET: Admin_manageController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Admin_manageController/Edit/5
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

		// GET: Admin_manageController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Admin_manageController/Delete/5
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
