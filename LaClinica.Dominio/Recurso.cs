using LaClinica.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public abstract class Recurso
    {
        public int Id { get; set; }

        public abstract string Descripcion();

        public EstadoRecurso Estado { get; set; }

        //Actualizar estado

    }
}
