using LanchesMVC.Models;
using LanchesMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMVC.Repositories
{
    public class LancheRepository: ILanchesRepository
    {
        private readonly AppDBContext _context;
        public LancheRepository(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);
        public Lanche GetLancheByID(int lancheID) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheID);
    }
}
