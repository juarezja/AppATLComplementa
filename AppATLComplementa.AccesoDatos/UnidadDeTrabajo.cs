using AppATLComplementa.Nucleo;
using AppATLComplementa.Nucleo.Repositorios;
using AppATLComplementa.AccesoDatos.Repositorios;


namespace AppATLComplementa
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private readonly ATLComplementaContexto _contexto;

        public UnidadDeTrabajo(ATLComplementaContexto contexto)
        {
            _contexto = contexto;
            ReferenciaDePago = new ReferenciaDePagoRepositorio(_contexto);
        }

        public IReferenciaDePagoRepositorio ReferenciaDePago { get; private set; }

        public int Complete()
        {
            return _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }

}
