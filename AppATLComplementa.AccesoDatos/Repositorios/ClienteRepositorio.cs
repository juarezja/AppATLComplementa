using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppATLComplementa.Negocio.Dominio;
using AppATLComplementa.Nucleo.Repositorios;

namespace AppATLComplementa.AccesoDatos.Repositorios
{
    public class ClienteRepositorio : Repositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ATLComplementaContexto contexto) : base(contexto)
        {
        }

        public ATLComplementaContexto ATLComplementaContexto
        {
            get { return Context as ATLComplementaContexto; }
        }

        public IEnumerable<Cliente> TraerPredio(int predio)
        {
            return ATLComplementaContexto.Clientes.Where(c => c.CntClave == predio).ToList();
        }

    }
}
