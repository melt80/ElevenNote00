namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "ClassSubject", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "ClassSubject");
        }
    }
}
