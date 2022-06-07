using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public class Turno: Recurso
    {
        public DateTime? Hora { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Telefono { get; set; }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
