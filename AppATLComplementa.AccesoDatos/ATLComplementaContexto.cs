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
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientePersona> ClientesPersonas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReferenciaDePagoConfiguracion());
            modelBuilder.Configurations.Add(new ClienteConfiguracion());
            modelBuilder.Configurations.Add(new ClientePersonaConfiguracion());
        }
    }
}