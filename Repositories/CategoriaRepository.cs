using LanchesMVC.Models;
using LanchesMVC.Repositories.Interfaces;

namespace LanchesMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDBContext _context;
        public CategoriaRepository(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
