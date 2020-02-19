namespace AppATLComplementa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearClientesyClientesPersonas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        CliClave = c.Int(nullable: false, identity: true),
                        CntClave = c.Int(nullable: false),
                        CliNumDer = c.Short(nullable: false),
                        CliNumToma = c.Short(nullable: false),
                        CliDependencia = c.Int(nullable: false),
                        GirClave = c.Short(nullable: false),
                        MatTubClave = c.Short(nullable: false),
                        MedClave = c.Int(nullable: false),
                        CorClave = c.Int(nullable: false),
                        EdoComClave = c.Short(nullable: false),
                        EdoTomClave = c.Short(nullable: false),
                        EdoSerClave = c.Short(nullable: false),
                        NivTarClave = c.Short(nullable: false),
                        TipAbaClave = c.Short(nullable: false),
                        TipDreClave = c.Short(nullable: false),
                        TipEdiClave = c.Short(nullable: false),
                        TipSerClave = c.Short(nullable: false),
                        DirClave = c.Int(nullable: false),
                        CliDirEntrega = c.Int(nullable: false),
                        CliDirFactura = c.Int(nullable: false),
                        CliPerClave = c.Int(nullable: false),
                        CliIndPropietario = c.Int(nullable: false),
                        CliIndResponsable = c.Int(nullable: false),
                        CliIndFiscal = c.Int(nullable: false),
                        CliComentario = c.String(),
                        CliFechaAlta = c.DateTime(nullable: false),
                        CliFechaRegistro = c.DateTime(nullable: false),
                        CliHabitantes = c.Short(nullable: false),
                        CliHidConsumoFijo = c.Single(nullable: false),
                        CliHidConsumoAcum = c.Single(nullable: false),
                        CliHidConsumoPromedio = c.Single(nullable: false),
                        CliHidDiametroDeDescarga = c.Short(nullable: false),
                        CliHidDiametroDeToma = c.Short(nullable: false),
                        CliMetrosConstruidos = c.Single(nullable: false),
                        CliDrenajeExtra = c.Single(nullable: false),
                        CliEsMedido = c.Int(nullable: false),
                        CliLLave1 = c.String(),
                        CliLLave2 = c.String(),
                        CliLLave3 = c.String(),
                        CliLLave4 = c.String(),
                        CliLLave5 = c.String(),
                        CliAdi01Clave = c.Short(nullable: false),
                        CliAdi02Clave = c.Short(nullable: false),
                        CliAdi03Clave = c.Short(nullable: false),
                        CliAdi04Clave = c.Short(nullable: false),
                        CliAdi05Clave = c.Short(nullable: false),
                        CliAdi06Clave = c.Short(nullable: false),
                        CliAdi07Clave = c.Short(nullable: false),
                        CliAdi08Clave = c.Short(nullable: false),
                        CliAdi09Clave = c.Short(nullable: false),
                        CliAdi10Clave = c.Short(nullable: false),
                        CliAdi11 = c.Single(nullable: false),
                        CliAdi12 = c.Single(nullable: false),
                        CliAdi13 = c.Single(nullable: false),
                        CliAdi14 = c.Single(nullable: false),
                        CliAdi15 = c.Single(nullable: false),
                        CliAdi16 = c.String(),
                        CliAdi17 = c.String(),
                        CliAdi18 = c.String(),
                        CliAdi19 = c.String(),
                        CliAdi20 = c.String(),
                        CliPeriodosDeAdeudo = c.Short(nullable: false),
                        CliSaldoTotal = c.Single(nullable: false),
                        CliSaldoFacturacion = c.Single(nullable: false),
                        CliSaldoConvenios = c.Single(nullable: false),
                        CliSaldoOtros = c.Single(nullable: false),
                        CliSaldoACuenta = c.Single(nullable: false),
                        CliCoordenadaX = c.Int(nullable: false),
                        CliCoordenadaY = c.Int(nullable: false),
                        CliCoordenadaZ = c.Int(nullable: false),
                        PerClave = c.Short(nullable: false),
                        ColClave = c.Short(nullable: false),
                        CalClave = c.Short(nullable: false),
                        RutClave = c.Short(nullable: false),
                        Rn1Clave = c.Short(nullable: false),
                        Rn2Clave = c.Short(nullable: false),
                        RutSecuencia = c.Short(nullable: false),
                        CliMjoCtaBase = c.Single(nullable: false),
                        CliMjoCtaIVA = c.Single(nullable: false),
                        CliUltimoPeriodoPagado = c.Short(nullable: false),
                        CliComentLectura = c.String(),
                        CliDirNotificacion = c.Int(nullable: false),
                        CliMedidorDentro = c.Short(nullable: false),
                        MetPagClave = c.Short(nullable: false),
                        EmpMetodoDePagoCuenta = c.String(),
                        SecHidClave = c.Int(nullable: false),
                        CliPrecintoSerie = c.String(),
                        CliPrecintoColor = c.String(),
                        PreColClave = c.Short(nullable: false),
                        CliPrecintoOrden = c.Int(nullable: false),
                        LecAleClave = c.Short(nullable: false),
                        CliPasswordInternet = c.String(),
                    })
                .PrimaryKey(t => t.CliClave);
            
            CreateTable(
                "dbo.ClientesPersonas",
                c => new
                    {
                        CliPerClave = c.Int(nullable: false, identity: true),
                        CliPerNombre = c.String(),
                        CliPerPaterno = c.String(),
                        CliPerMaterno = c.String(),
                        CliPerNombreOrazon = c.String(),
                        PerGenClave = c.Short(nullable: false),
                        EmpPerTipClave = c.Short(nullable: false),
                        CliPerIfe = c.String(),
                        CliPerRFC = c.String(),
                        CliPerCURP = c.String(),
                        TelTipClave = c.Short(nullable: false),
                        TelTipClave2 = c.Short(nullable: false),
                        TelTipClave3 = c.Short(nullable: false),
                        TelTipClave4 = c.Short(nullable: false),
                        CliPerTelefono1 = c.String(),
                        CliPerTelefono2 = c.String(),
                        CliPerTelefono3 = c.String(),
                        CliPerTelefono4 = c.String(),
                        CliPerFechaNacimiento = c.DateTime(nullable: false),
                        CliPerEmail01 = c.String(),
                        CliPerEmail02 = c.String(),
                        CliPerEnviaCFD = c.Short(nullable: false),
                        CliPerTelefonoForaneo = c.String(),
                        CliPerExtension = c.String(),
                        CliClaveMigracion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CliPerClave);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientesPersonas");
            DropTable("dbo.Clientes");
        }
    }
}
