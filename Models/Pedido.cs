using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    [Table("lanches", Schema = "pedidos")]
    public class Pedido
    {
        [Key]
        [Column("id")]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(50)]
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome")]
        [StringLength(50)]
        [Column("sobrenome")]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o seu endereço")]
        [StringLength (100)]
        [Column("endereco")]
        [Display (Name = "Endereço")]
        public string Endereco { get; set; }

        [StringLength(100)]
        [Column("complemento")]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe o seu CEP")]
        [StringLength(10, MinimumLength = 8)]
        [Column("cep")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [StringLength(10)]
        [Column("estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [StringLength(50)]
        [Column("cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o seu telefone")]
        [StringLength(25)]
        [Column("telefone")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        [StringLength(50)]
        [Column("email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(
            @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto"
        )]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Total do pedido")]
        public decimal totalPedido { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Itens no pedido")]
        public int totalItensPedido { get; set; }

        [Column("datapedido")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data do pedido")]
        //[DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime dataPedido { get; set; }

        [Column("dataenvio")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de envio do pedido")]
        //[DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? dataEnvio { get; set; }

        public List<PedidoDetalhe> PeditoItens { get; set; }
    }
}
