using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auvo.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Key]
        public int CidadeId { get; set; }

        [Column("Nome")]
        [Required]
        [Display(Name = "Nome da cidade")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Column("EstadoId")]
        [ForeignKey(name: "EstadoId")]
        [Required]
        [Display(Name = "Id do estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public List<PrevisaoClima> ListPrevisaoClima { get; set; }

    }
}
