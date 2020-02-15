using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppATLComplementa.Nucleo.Repositorios;

namespace AppATLComplementa.Nucleo
{
    public interface IUnidadDeTrabajo : IDisposable
    {
        IReferenciaDePagoRepositorio ReferenciaDePago { get; }

        int Complete();
    }
}
