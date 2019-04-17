namespace TryItOut.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoTasks",
                c => new
                    {
                        Identifier = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        RequiredBy = c.DateTime(nullable: false),
                        CompletedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Identifier);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoTasks");
        }
    }
}
