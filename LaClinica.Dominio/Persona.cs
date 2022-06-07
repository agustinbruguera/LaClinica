using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public ICollection<Llamada> Llamadas { get; set; }
    }
}
