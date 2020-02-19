using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using AppATLComplementa.Negocio.Dominio;


namespace AppATLComplementa.AccesoDatos.ConfiguracionesEntidad
{
    public class ClientePersonaConfiguracion : EntityTypeConfiguration<ClientePersona>
    {
        public ClientePersonaConfiguracion()
        {
            //Revocaciones de Tabla, por omisión el nombre de la clase en plural (pero en ingles)
            ToTable("ClientesPersonas");

            //Revocaciones de Primary Key, por omisión <clase>Id
            HasKey(c => c.CliPerClave);
        }
    }
}
