using LaClinica.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Presentacion.Models
{
    public class LlamadaViewModel
    {
        public LlamadaViewModel()
        {
            Sintomas = new List<LlamadaSintoma>();
        }

        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


        [Required(ErrorMessage = "Dato obligatorio")]
        [StringLength(8, MinimumLength = 7)]
        public int DNI { get; set; }
        [Required(ErrorMessage = "Dato obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Dato obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Dato obligatorio")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "Dato obligatorio")]
        public string Domicilio { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Dato obligatorio")]
        public EstadoLlamada Estado { get; set; }

        public ICollection<LlamadaSintoma> Sintomas { get; set; }
        [Required(ErrorMessage = "Dato obligatorio")]
        public Recurso Recurso { get; set; }
        [Required(ErrorMessage = "Dato obligatorio")]
        public Operador Operador { get; set; }

    }
}
