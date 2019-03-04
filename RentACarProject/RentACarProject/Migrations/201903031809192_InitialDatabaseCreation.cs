namespace RentACarProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 100),
                        Model = c.String(nullable: false, maxLength: 100),
                        Image = c.String(maxLength: 300),
                        EngineVolume = c.String(nullable: false, maxLength: 100),
                        HorsePower = c.String(nullable: false, maxLength: 100),
                        MotorType = c.String(nullable: false, maxLength: 100),
                        DateOfProduction = c.String(),
                        AmountOfMarch = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
