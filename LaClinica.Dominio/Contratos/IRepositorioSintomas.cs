using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Dominio.Contratos
{
    public interface IRepositorioSintomas
    {
        List<Sintoma> GetSintomas();

        void CreateSintoma(Sintoma sintoma);
    }
}
