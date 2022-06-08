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
    public class RepositorioSintomas : DbContext, IRepositorioSintomas
    {
        private readonly LaClinicaContext _context;

        public RepositorioSintomas(LaClinicaContext Context)
        {
            _context = Context;
        }

        public void CreateSintoma(Sintoma sintoma)
        {
            _context.Sintomas.Add(sintoma);
            _context.SaveChanges();
        }

        public List<Sintoma> GetSintomas()
        {
            return _context.Sintomas.ToList();
        }
    }
}
