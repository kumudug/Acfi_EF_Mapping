namespace AcfiDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acfi01CalculationDomain",
                c => new
                    {
                        AcfiCalculationDomainId = c.Int(nullable: false, identity: true),
                        Eating = c.Int(),
                        ReadinessToEat = c.Int(),
                    })
                .PrimaryKey(t => t.AcfiCalculationDomainId);
            
            AddForeignKey("dbo.AcfiCalculationDomains", "AcfiCalculationDomainId", "dbo.Acfi01CalculationDomain", "AcfiCalculationDomainId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AcfiCalculationDomains", "AcfiCalculationDomainId", "dbo.Acfi01CalculationDomain");
            DropTable("dbo.Acfi01CalculationDomain");
        }
    }
}
