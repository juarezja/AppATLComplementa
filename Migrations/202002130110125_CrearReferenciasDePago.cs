namespace AppATLComplementa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearReferenciasDePago : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReferenciasDePago",
                c => new
                    {
                        RefPagClave = c.Int(nullable: false, identity: true),
                        RefPagEmision = c.DateTime(nullable: false),
                        RefPagVencimiento = c.DateTime(nullable: false),
                        RefPagTotal = c.Single(nullable: false),
                        RefPagRedondeo = c.Single(nullable: false),
                        RefPagTotalRedondeado = c.Single(nullable: false),
                        RefPagDocumentos = c.Int(nullable: false),
                        EmpPerClave = c.Int(nullable: false),
                        RefPagHostName = c.String(),
                        RefPagReferencia = c.String(),
                        RefPagCancelada = c.Int(nullable: false),
                        CajTipDocClave = c.Int(nullable: false),
                        RefPagDocumentoClave = c.Int(nullable: false),
                        CliClave = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RefPagClave);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReferenciasDePago");
        }
    }
}
