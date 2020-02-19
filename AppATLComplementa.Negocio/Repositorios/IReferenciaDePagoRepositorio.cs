using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

using AppATLComplementa.Negocio.Dominio;

//Interfaz Cualquier operación especifica a este objeto que no tengamos en el repositorio generico
namespace AppATLComplementa.Nucleo.Repositorios
{
    public interface IReferenciaDePagoRepositorio : IRepositorio<ReferenciaDePago>
    {
        IEnumerable<ReferenciaDePago> TraerPorCliente(int cliente);
    }
}
