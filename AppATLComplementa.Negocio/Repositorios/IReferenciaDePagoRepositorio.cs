using AppATLComplementa.Negocio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace AppATLComplementa.Nucleo.Repositorios
{
    public interface IReferenciaDePagoRepositorio : IRepositorio<ReferenciaDePago>
    {
        IEnumerable<ReferenciaDePago> TraerTodos();
    }
}
