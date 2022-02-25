using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    [Table("carrinhocompraitens", Schema = "lanches")]
    public class CarrinhoCompra
    {
        private readonly AppDBContext _context;
        public CarrinhoCompra(AppDBContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinhoCompra(IServiceProvider services)
        {
            //Define a session
            ISession session = services.GetRequiredService<IHttpContextAccessor>().HttpContext.Session;
            //Get a service from our context type
            var context = services.GetService<AppDBContext>();
            //Get carrinho Id
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();
            //Set carrinho Id in the session
            session.SetString("CarrinhoId", carrinhoId);
            //Return the carrinho with a context and Id
            return new CarrinhoCompra(context) { CarrinhoCompraId = carrinhoId };
        }

        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var CarrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId && s.CarrinhoCompraId == CarrinhoCompraId
            );

            if (CarrinhoCompraItem == null)
            {
                CarrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };

                _context.CarrinhoCompraItems.Add(CarrinhoCompraItem);
            } else
            {
                CarrinhoCompraItem.Quantidade++;
            }

            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Lanche lanche)
        {
            var CarrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId && s.CarrinhoCompraId == CarrinhoCompraId
            );

            var quantidadeLocal = 0;

            if (CarrinhoCompraItem != null)
            {
                if (CarrinhoCompraItem.Quantidade > 1)
                {
                    CarrinhoCompraItem.Quantidade--;
                    quantidadeLocal = CarrinhoCompraItem.Quantidade;
                } else
                {
                    _context.CarrinhoCompraItems.Remove(CarrinhoCompraItem);
                }
            }

            _context.SaveChanges();
            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItems()
        {
            return CarrinhoCompraItems ?? (
                CarrinhoCompraItems = _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraId == CarrinhoCompraId).Include(s => s.Lanche).ToList()
            );
        }

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItems.RemoveRange(carrinhoItens);
            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            return _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraId == CarrinhoCompraId).Select(c => c.Lanche.Preco * c.Quantidade).Sum();
        }
    }
}
