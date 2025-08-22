using FinanceApp.Models;
using FinanceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FinanceApp.Controllers
{
    public class ExpencesController : Controller
    {
        private readonly IExpencesService _expencesService;

        public ExpencesController(IExpencesService expencesService)
        {
            _expencesService = expencesService;
        }

        public async Task<IActionResult> Index()
        {
            var expences = await _expencesService.GetAllAsync();
            return View(expences);
        }
        public async Task<IActionResult> Details(int id)
        {
            var expence = await _expencesService.GetByIdAsync(id);
            if (expence == null)
            {
                return NotFound();
            }
            return View(expence);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Expences expence)
        {
            if (ModelState.IsValid)
            {
                await _expencesService.AddAsync(expence);
                return RedirectToAction(nameof(Index));
            }
            return View(expence);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var expence = await _expencesService.GetByIdAsync(id);
            if (expence == null)
            {
                return NotFound();
            }
            return View(expence);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Expences expence)
        {
            if (id != expence.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _expencesService.UpdateAsync(expence);
                return RedirectToAction(nameof(Index));
            }
            return View(expence);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var expence = await _expencesService.GetByIdAsync(id);
            if (expence == null)
            {
                return NotFound();
            }
            return View(expence);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _expencesService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> GetChartDataAsync()
        {
            var data = await _expencesService.GetChartDataAsync();
            return Json(data);
        }

    }
}
