using System.ComponentModel.DataAnnotations;

namespace GestionResiduos.Models
{
    public class Residuo
    {
        [Key]
        public int IdResiduo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [Display(Name = "Nombre del residuo")]
        public string NameResiduo { get; set; }

        [Required]
        [Display(Name = "Tipo de residuo")]
        public string TipoResiduo { get; set; }

        [Range(0.1, 10000)]
        [Display(Name = "Peso (KG)")]
        public double PespResiduo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Recoleccion")]
        public DateTime FechaRecoleccionResiduo { get; set; }

    }
}
