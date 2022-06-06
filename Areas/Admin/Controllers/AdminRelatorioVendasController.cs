using LanchesMVC.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRelatorioVendasController : Controller
    {
        private readonly RelatorioVendaService relatorioVendaService;

        public AdminRelatorioVendasController(RelatorioVendaService relatorioVendaService)
        {
            this.relatorioVendaService = relatorioVendaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RelatorioVendaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            if (!maxDate.HasValue)
                maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await relatorioVendaService.FindByDateAsync(minDate, maxDate);

            return View(result);
        }
    }
}
