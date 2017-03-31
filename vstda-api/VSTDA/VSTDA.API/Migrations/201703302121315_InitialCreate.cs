namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        TodoItemId = c.Int(nullable: false, identity: true),
                        task = c.String(),
                        priority = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TodoItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoItems");
        }
    }
}
