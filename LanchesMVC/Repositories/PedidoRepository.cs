using LanchesMVC.Models;
using LanchesMVC.Repositories.Interfaces;

namespace LanchesMVC.Repositories
{
    public class PedidoRepository: IPedidoRepository
    {
        private readonly AppDBContext _appDBContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDBContext appDBContext, CarrinhoCompra carrinhoCompra)
        {
            _appDBContext = appDBContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.dataEnvio = DateTime.Now;
            _appDBContext.Pedidos.Add(pedido);
            _appDBContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;

            foreach (var carrinhoCompra in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoCompra.Quantidade,
                    LancheId = carrinhoCompra.Lanche.LancheId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoCompra.Lanche.Preco
                };

                _appDBContext.PedidosDetalhes.Add(pedidoDetail);
            }

            _appDBContext.SaveChanges();
        }
    }
}
