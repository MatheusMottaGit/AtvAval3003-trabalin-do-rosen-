using Microsoft.AspNetCore.Mvc;
using academico.Models;
using academico.Repositories;

namespace academico.Controllers
{
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepository _repo;

        public ProjetoController(IProjetoRepository repo)
        {
            _repo = repo;
        }

        // GET: Projeto
        public async Task<IActionResult> Index()
        {
            var projetos = await _repo.GetAll();
            return View(projetos);
        }

        // GET: Projeto/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var projeto = await _repo.GetById(id);
            if (projeto == null)
            {
                return NotFound();
            }
            return View(projeto);
        }

        // GET: Projeto/Create
        public IActionResult Create()
        {
            return View(new Projeto());
        }

        // POST: Projeto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                await _repo.Create(projeto);
                return RedirectToAction(nameof(Index));
            }
            return View(projeto);
        }

        // GET: Projeto/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var projeto = await _repo.GetById(id);
            if (projeto == null)
            {
                return NotFound();
            }
            return View(projeto);
        }

        // POST: Projeto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Projeto projeto)
        {
            if (id != projeto.ProjetoId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _repo.Edit(projeto);
                return RedirectToAction(nameof(Index));
            }
            return View(projeto);
        }

        // GET: Projeto/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var projeto = await _repo.GetById(id);
            if (projeto == null)
            {
                return NotFound();
            }
            return View(projeto);
        }

        // POST: Projeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}