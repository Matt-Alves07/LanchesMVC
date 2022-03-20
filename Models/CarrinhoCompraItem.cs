using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    [Table("carrinhocompraitens", Schema = "lanches")]
    public class CarrinhoCompraItem
    {
        [Key]
        [Column("id")]
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
