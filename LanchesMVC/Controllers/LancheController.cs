using LanchesMVC.Models;
using LanchesMVC.Repositories.Interfaces;
using LanchesMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMVC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;
        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string _categoria)
        {
            IEnumerable<Lanche> Lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(_categoria))
            {
                Lanches = _lancheRepository.Lanches
                    .OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                Lanches = _lancheRepository.Lanches
                    .Where(l => l.Categoria.Nome.Equals(_categoria, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(c => c.Nome);

                categoriaAtual = _categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = Lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }
    }
}
