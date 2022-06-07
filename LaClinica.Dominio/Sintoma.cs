using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public class Sintoma
    {
        public Sintoma()
        {
            Llamadas = new List<LlamadaSintoma>();                          
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public int NivelId { get; set; }
        public Nivel Nivel { get; set; }
        public ICollection<LlamadaSintoma> Llamadas { get; set; }
        //public int LlamadaID { get; set; }
        //public Llamada Llamada { get; set; }
    }
}
