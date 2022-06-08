using LaClinica.Dominio;
using LaClinica.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Datos.Repository
{
    public class RepositorioLlamadaAdaptador : RepositorioLlamadas, IRepositorioLlamadaAdaptador
    {
        private readonly LaClinicaContext _context;
        public RepositorioLlamadaAdaptador(LaClinicaContext Context) : base(Context)
        {
        }

        public void GetList(List<Llamada> Llamadas)
        {
            
            _context.Llamadas = Llamadas;
            GetLlamada(llam);
        }
    }
}
