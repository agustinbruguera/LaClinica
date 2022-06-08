using LaClinica.Dominio;
using LaClinica.Dominio.Contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaClinica.Datos.Repository
{
    public class RepositorioLlamadas : DbContext, IRepositorioLlamadas
    {
        private readonly LaClinicaContext _context;

        public RepositorioLlamadas(LaClinicaContext Context)
        {
            _context = Context;
        }

        public void CreateLlamada(Llamada Llamada)
        {
            _context.Llamadas.Add(Llamada);
            _context.SaveChanges();
        }

        public List<Llamada> GetLlamada()
        {
            return _context.Llamadas.ToList();
        }
    }
}
