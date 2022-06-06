using LanchesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMVC.Areas.Admin.Services
{
    public class RelatorioVendaService
    {
        private readonly AppDBContext _context;

        public RelatorioVendaService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.Pedidos select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.dataEnvio >= minDate.Value.ToUniversalTime());
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.dataEnvio <= maxDate.Value.ToUniversalTime());
            }

            return await resultado
                            .Include(l => l.PeditoItens)
                            .ThenInclude(l => l.Lanche)
                            .OrderByDescending(x => x.dataEnvio)
                            .ToListAsync();
        }
    }
}
