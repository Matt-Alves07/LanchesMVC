using LanchesMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMVC.Components
{
    public class CategoriaMenu: ViewComponent
    {
        private readonly ICategoriaRepository categoriaRepository;
        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = categoriaRepository.Categorias.OrderBy(c => c.Nome);
            return View(categoria);
        }
    }
}
