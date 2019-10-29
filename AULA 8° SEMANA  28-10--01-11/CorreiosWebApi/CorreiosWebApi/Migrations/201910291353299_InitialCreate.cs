namespace CorreiosWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(maxLength: 50),
                        Bairro = c.String(maxLength: 50),
                        CEP = c.Int(nullable: false),
                        UF = c.String(maxLength: 2),
                        Municipio = c.String(maxLength: 30),
                        Complemento = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Enderecoes");
        }
    }
}
