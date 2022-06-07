using LaClinica.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
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

        public EstadoLlamada Estado { get; set; }





        //public ICollection<Sintoma> Sintomas { get; set; }

        public ICollection<LlamadaSintoma> Sintomas { get; set; }

        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }

        public int OperadorId { get; set; }
        public Operador Operador { get; set; }

    }
}
