namespace CorreiosWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altera2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Enderecoes");
            AddColumn("dbo.Enderecoes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Enderecoes", "Id");
            DropColumn("dbo.Enderecoes", "Key");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enderecoes", "Key", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Enderecoes");
            DropColumn("dbo.Enderecoes", "Id");
            AddPrimaryKey("dbo.Enderecoes", "Key");
        }
    }
}
