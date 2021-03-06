using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    [Table("lanches", Schema = "pedidosdetalhes")]
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }
        public int PedidoId { get; set; }
        public int LancheId { get; set; }
        public int Quantidade { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Preco { get; set; }

        public virtual Lanche Lanche { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
