using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppATLComplementa.Negocio.Dominio;
using AppATLComplementa.Nucleo.Repositorios;


namespace AppATLComplementa.AccesoDatos.Repositorios
{
    public class ReferenciaDePagoRepositorio : Repositorio<ReferenciaDePago>, IReferenciaDePagoRepositorio
    {
        public ReferenciaDePagoRepositorio(ATLComplementaContexto contexto) : base(contexto)
        {
        }

        public IEnumerable<ReferenciaDePago> TraerTodos()
        {
            return ATLComplementaContexto.ReferenciasDePago.OrderBy(r => r.RefPagClave).ToList();
        }

        public ATLComplementaContexto ATLComplementaContexto
        {
            get { return Context as ATLComplementaContexto; }
        }
    }
}
