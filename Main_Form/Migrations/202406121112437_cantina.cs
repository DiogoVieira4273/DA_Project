namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cantina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIF = c.Int(nullable: false),
                        Saldo = c.Decimal(precision: 18, scale: 2),
                        NumEstudante = c.Int(),
                        Email = c.String(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataHora = c.DateTime(nullable: false),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.ItemFaturas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fatura_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Faturas", t => t.Fatura_ID)
                .Index(t => t.Fatura_ID);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(),
                        Menu_Id = c.Int(),
                        Multa_ID = c.Int(),
                        Prato_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadores", t => t.Cliente_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Multas", t => t.Multa_ID)
                .ForeignKey("dbo.Pratoes", t => t.Prato_ID)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Menu_Id)
                .Index(t => t.Multa_ID)
                .Index(t => t.Prato_ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        QuantidadeDisponivel = c.Int(nullable: false),
                        PrecoEstudante = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoProfessor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumHoras = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.String(),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Quantidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantidade = c.Int(nullable: false),
                        Extra_ID = c.Int(),
                        Menu_Id = c.Int(),
                        Prato_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Extras", t => t.Extra_ID)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .ForeignKey("dbo.Pratoes", t => t.Prato_ID)
                .Index(t => t.Extra_ID)
                .Index(t => t.Menu_Id)
                .Index(t => t.Prato_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quantidades", "Prato_ID", "dbo.Pratoes");
            DropForeignKey("dbo.Quantidades", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Quantidades", "Extra_ID", "dbo.Extras");
            DropForeignKey("dbo.Faturas", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "Prato_ID", "dbo.Pratoes");
            DropForeignKey("dbo.Reservas", "Multa_ID", "dbo.Multas");
            DropForeignKey("dbo.Reservas", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Extras", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "Cliente_Id", "dbo.Utilizadores");
            DropForeignKey("dbo.ItemFaturas", "Fatura_ID", "dbo.Faturas");
            DropIndex("dbo.Quantidades", new[] { "Prato_ID" });
            DropIndex("dbo.Quantidades", new[] { "Menu_Id" });
            DropIndex("dbo.Quantidades", new[] { "Extra_ID" });
            DropIndex("dbo.Reservas", new[] { "Prato_ID" });
            DropIndex("dbo.Reservas", new[] { "Multa_ID" });
            DropIndex("dbo.Reservas", new[] { "Menu_Id" });
            DropIndex("dbo.Reservas", new[] { "Cliente_Id" });
            DropIndex("dbo.ItemFaturas", new[] { "Fatura_ID" });
            DropIndex("dbo.Faturas", new[] { "Reserva_Id" });
            DropIndex("dbo.Extras", new[] { "Reserva_Id" });
            DropTable("dbo.Quantidades");
            DropTable("dbo.Pratoes");
            DropTable("dbo.Multas");
            DropTable("dbo.Menus");
            DropTable("dbo.Reservas");
            DropTable("dbo.ItemFaturas");
            DropTable("dbo.Faturas");
            DropTable("dbo.Extras");
            DropTable("dbo.Utilizadores");
        }
    }
}
