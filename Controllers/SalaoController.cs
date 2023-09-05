using Microsoft.AspNetCore.Mvc;
using Salao_De_Cabeleireiro.Data;
using Salao_De_Cabeleireiro.Models;
using System.Net.Http.Headers;

namespace Salao_De_Cabeleireiro.Controllers
{
    public class SalaoController : Controller
    {
        readonly private ApplicationDbContext _db;

        public SalaoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<SalaoModel> salao = _db.Salao;
            return View(salao);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(SalaoModel salao)
        {
            if (ModelState.IsValid)
            {
                _db.Salao.Add(salao);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            SalaoModel salao = _db.Salao.FirstOrDefault(x => x.Id == id);

            if (salao == null)
            {
                return NotFound();
            }

            return View(salao);
        }

        [HttpPost]
        public IActionResult Editar(SalaoModel salao)
        {
            if (ModelState.IsValid)
            {
                _db.Salao.Update(salao);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(salao);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            SalaoModel salao = _db.Salao.FirstOrDefault(x => x.Id == id);

            if (salao == null)
            {
                return NotFound();
            }

            return View(salao);
        }

        [HttpPost]
        public IActionResult Excluir(SalaoModel salao)
        {
            if (salao == null)
            {
                return NotFound();
            }
            _db.Salao.Remove(salao);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}