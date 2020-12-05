using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaAppVSCode.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage="O campo Titulo eh obrigatorio!")]
        public string Titulo { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.DateTime, ErrorMessage="Data em formato incorreto.")]
        [Required(ErrorMessage="O campo Data de Lancamento eh obrigatorio!")]
        public DateTime DataLancamento { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Genero { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Avaliacao { get; set; }
    }
}