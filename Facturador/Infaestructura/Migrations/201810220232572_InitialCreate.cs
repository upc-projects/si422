namespace Infaestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comprobante",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Cliente = c.String(nullable: false, maxLength: 300, unicode: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Creado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ComprobanteDetalle",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ComprobanteId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Monto = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Producto", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Comprobante", t => t.ComprobanteId)
                .Index(t => t.ComprobanteId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 300, unicode: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComprobanteDetalle", "ComprobanteId", "dbo.Comprobante");
            DropForeignKey("dbo.ComprobanteDetalle", "ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Producto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "CategoriaId" });
            DropIndex("dbo.ComprobanteDetalle", new[] { "ProductoId" });
            DropIndex("dbo.ComprobanteDetalle", new[] { "ComprobanteId" });
            DropTable("dbo.Producto");
            DropTable("dbo.ComprobanteDetalle");
            DropTable("dbo.Comprobante");
            DropTable("dbo.Categoria");
        }
    }
}
