using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    [Table("categoria", Schema = "lanches")]
    public class Categoria
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        [Required(ErrorMessage = "O nome da categoria deve ser preenchido.")]
        public String Nome { get; set; }
        [Column("descricao")]
        [Required(ErrorMessage = "A descrição da categoria deve ser preenchida.")]
        [MinLength(20, ErrorMessage = "A descrição da categoria deve ter no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição da categoria não deve ter mais de {1} caracteres.")]
        public String Descricao { get; set; }

        //Lanches
        public List<Lanche> Lanches { get; set;}
    }
}
