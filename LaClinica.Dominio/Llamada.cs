using LaClinica.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public class Llamada
    {
        public Llamada()
        {
            Sintomas = new List<LlamadaSintoma>();
        }

        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public DateTime Fecha { get; set; }
        
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public EstadoLlamada Estado { get; set; }

        //public ICollection<Sintoma> Sintomas { get; set; }

        public ICollection<LlamadaSintoma> Sintomas { get; set; }

        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }

        public int OperadorId { get; set; }
        public Operador Operador { get; set; }

    }
}
