using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using AppATLComplementa.Negocio.Dominio;

namespace AppATLComplementa.AccesoDatos.ConfiguracionesEntidad
{
    public class ClienteConfiguracion : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguracion()
        {
            //Revocaciones de Tabla, por omisión el nombre de la clase en plural (pero en ingles)
            ToTable("Clientes");

            //Revocaciones de Primary Key, por omisión <clase>Id
            HasKey(c => c.CliClave);

            HasRequired(c => c.ClientePersona)
                .WithMany(p => p.Clientes)
                .HasForeignKey(c => c.CliPerClave);

        }
    }
}
