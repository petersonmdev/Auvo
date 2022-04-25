using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auvo.Models
{
    [Table("PrevisaoClima")]
    public class PrevisaoClima
    {
        [Column("Id")]
        [Key]
        public int PrevisaoClimaId { get; set; }

        [Column("DataPrevisao")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Data da previsão")]
        public DateTime DataPrevisao { get; set; }

        [Column("Clima")]
        [Required]
        [Display(Name = "Clima da previsão")]
        [StringLength(15)]
        public string Clima { get; set; }

        [Column("TemperaturaMinima", TypeName = "numeric(3,1)")]
        [Display(Name = "Temperatura minima")]
        public float? TemperaturaMinima { get; set; }

        [Column("TemperaturaMaxima", TypeName = "numeric(3,1)")]
        [Display(Name = "Temperatura máxima")]
        public float? TemperaturaMaxima { get; set; }

        [Column("CidadeId")]
        [ForeignKey(name: "CidadeId")]
        [Required]
        [Display(Name = "Id da cidade")]
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
