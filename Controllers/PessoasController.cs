using BurguerQuest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BurguerQuest.Controllers
{
    public class PessoasController : Controller
    {   
        private readonly AppDbContext _pessoas;
        public PessoasController(AppDbContext Pessoas)
        {
            _pessoas = Pessoas;
        }

        public async Task<IActionResult> Cadastro()
        {
            var dados = await _pessoas.pessoas.ToListAsync();

            return View(dados);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Pessoas pessoas)
        {
            if(ModelState.IsValid)
            {
                _pessoas.pessoas.Add(pessoas);
                await _pessoas.SaveChangesAsync();
                return RedirectToAction("Cadastro");
            }
            return View(pessoas);
        }
    }
}