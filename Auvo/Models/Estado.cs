using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auvo.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Key]
        public int EstadoId { get; set; }

        [Column("Nome")]
        [Required]
        [Display(Name = "Nome do estado")]
        [StringLength(200)]
        public string Nome { get; set; }

        [Column("UF")]
        [Required]
        [Display(Name = "Nome da Unidade Federativa")]
        [StringLength(2)]
        public string UF { get; set; }
        public List<Cidade> ListCidade { get; set; }

    }
}
