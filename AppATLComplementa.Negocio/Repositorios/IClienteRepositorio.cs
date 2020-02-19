using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppATLComplementa.Negocio.Dominio;

namespace AppATLComplementa.Nucleo.Repositorios
{
    public interface IClienteRepositorio : IRepositorio<Cliente>
    {
        IEnumerable<Cliente> TraerPredio(int predio);
    }
}
