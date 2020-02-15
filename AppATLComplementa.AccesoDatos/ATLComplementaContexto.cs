using AppATLComplementa.Negocio.Dominio;
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AppATLComplementa.AccesoDatos.ConfiguracionesEntidad;


namespace AppATLComplementa
{
    public partial class ATLComplementaContexto : DbContext
    {
        public ATLComplementaContexto()
            : base("name=ATLComplementaContexto")
        {
        }

        public virtual DbSet<ReferenciaDePago> ReferenciasDePago { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReferenciaDePagoConfiguracion());
        }
    }
}