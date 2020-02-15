using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using AppATLComplementa.Negocio.Dominio;

namespace AppATLComplementa.AccesoDatos.ConfiguracionesEntidad
{
    public class ReferenciaDePagoConfiguracion : EntityTypeConfiguration<ReferenciaDePago>
    {
        public ReferenciaDePagoConfiguracion()
        {
            //Revocaciones de Tabla, por omisión el nombre de la clase en plural (pero en ingles)
            ToTable("ReferenciasDePago");

            //Revocaciones de Primary Key, por omisión <clase>Id
            HasKey(r => r.RefPagClave);

            //Configurar Propiedades, ordenadas alfabeticamente
            //Property(e => e.Nombre)
            //.HasMaxLength(30)
            //.IsUnicode(false);

            //Configurar Relaciones, ordenadas alfabeticamente
            //HasMany(a => a.Etapas)
            //.WithRequired(e => e.AreaResponsabilidad)
            //.WillCascadeOnDelete(false);

            //HasMany(a => a.Flujos)
            //.WithRequired(f => f.AreaResponsabilidad)
            //.WillCascadeOnDelete(false);

            //HasMany(a => a.PersonasTramite)
            //.WithRequired(p => p.AreaResponsabilidad)
            //.HasForeignKey(e => e.AreaResponsabilidadId)
            //.WillCascadeOnDelete(false);

            //HasMany(a => a.PrestamosExpediente)
            //.WithRequired(p => p.AreaResponsabilidad)
            //.HasForeignKey(e => e.AreaResponsabilidadIdSalida)
            //.WillCascadeOnDelete(false);
        }
    }
}
