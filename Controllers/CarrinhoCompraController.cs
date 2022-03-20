using LanchesMVC.Models;
using LanchesMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LanchesMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace LanchesMVC.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILanchesRepository lanchesRepository,CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lanchesRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        [Authorize]
        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            var lancheselecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);

            if (lancheselecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheselecionado);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoverDoCarrinhoCompra(int lancheId)
        {
            var lancheselecionado = _lancheRepository.Lanches.FirstOrDefault(p=> p.LancheId==lancheId);

            if (lancheselecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheselecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
