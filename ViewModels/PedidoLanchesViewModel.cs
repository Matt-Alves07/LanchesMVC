using LanchesMVC.Models;

namespace LanchesMVC.ViewModels
{
    public class PedidoLanchesViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhe { get; set; }
    }
}
