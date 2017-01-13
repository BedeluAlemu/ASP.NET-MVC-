namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'JAZZ')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'HIP-HOP')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'BLUES')");
            Sql("INSERT INTO Genres(Id,Name) VALUES (4,'ROCK')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,'COUNTRY')");
        }
        
        public override void Down()
        {
        }
    }
}
