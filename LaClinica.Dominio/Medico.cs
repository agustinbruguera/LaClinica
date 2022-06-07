using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public class Medico: Recurso
    {
        public string Nombre { get; set; }
        public int? Legajo { get; set; }

        public override string Descripcion()
        {
            throw new NotImplementedException();
        }
    }
}
