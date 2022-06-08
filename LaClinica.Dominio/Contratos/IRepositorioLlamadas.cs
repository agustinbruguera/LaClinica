using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio.Contratos
{
    public interface IRepositorioLlamadas
    {
        List<Llamada> GetLlamada();

        void CreateLlamada(Llamada Llamada);
    }
}
