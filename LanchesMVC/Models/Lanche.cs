﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    [Table("lanches", Schema = "lanches")]
    public class Lanche
    {
        [Key]
        [Column("id")]
        public Int32 LancheId { get; set; }
        [Column("nome")]
        [Required(ErrorMessage = "O nome do lanche deve ser preenchido.")]
        [Display(Name = "Nome do Lanche")]
        public String Nome { get; set; }
        [Column("descricaocurta")]
        [Required(ErrorMessage = "A descrição do lanche deve ser preenchida.")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "A descrição do lanche deve ter no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição do lanche não pode exceder {1} caracteres.")]
        public String DescricaoCurta { get; set; }
        [Column("descricadetalhada")]
        public String DescricaoDetalhada { get; set; }
        [Column("preco")]
        [Required(ErrorMessage = "O preço do lanche deve ser preenchido.")]
        public Decimal Preco { get; set; }
        [Column("imagemurl")]
        public String ImagemUrl { get; set; }
        [Column("imagemthumbnailurl")]
        public String ImagemThumbnailUrl { get; set; }
        [Column("islanchepreferido")]
        public Boolean IsLanchePreferido { get; set; }
        [Column("emestoque")]
        public Boolean EmEstoque { get; set; }

        //Categoria
        [Column("categoriaid")]
        public Int32 CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
