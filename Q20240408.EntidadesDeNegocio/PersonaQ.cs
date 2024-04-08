using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q20240408.EntidadesDeNegocio
{
    public class PersonaQ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string NombreQ { get; set; }
        [Required]
        [StringLength(60)]
        public string ApellidoQ { get; set; }
        public DateTime FechaNacimientoQ { get; set; }
        public decimal SueldoQ { get; set; }
        public byte StatusQ { get; set; }
    }
}
