namespace IMC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Peso = c.Double(nullable: false),
                        Altura = c.Double(nullable: false),
                        Imc = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Table");
        }
    }
}
