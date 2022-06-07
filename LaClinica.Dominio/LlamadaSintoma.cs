using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public class LlamadaSintoma
    {
        public int Id { get; set; }
        public int LlamadaId { get; set; }
        public Llamada Llamada { get; set; }

        public int SintomaId { get; set; }
        public Sintoma Sintoma { get; set; }
    }
}
