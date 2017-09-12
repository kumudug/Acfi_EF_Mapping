namespace AcfiDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital_create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acfi01CalculationDomain",
                c => new
                    {
                        AcfiCalculationDomainId = c.Int(nullable: false),
                        Eating = c.Int(),
                        ReadinessToEat = c.Int(),
                    })
                .PrimaryKey(t => t.AcfiCalculationDomainId)
                .ForeignKey("dbo.AcfiCalculationDomains", t => t.AcfiCalculationDomainId)
                .Index(t => t.AcfiCalculationDomainId);
            
            CreateTable(
                "dbo.AcfiCalculationDomains",
                c => new
                    {
                        AcfiCalculationDomainId = c.Int(nullable: false, identity: true),
                        AcfiCalculationDomainScopeId = c.Int(nullable: false),
                        AcfiDomainId = c.Int(nullable: false),
                        IsViewed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AcfiCalculationDomainId)
                .ForeignKey("dbo.AcfiCalculationDomainScopes", t => t.AcfiCalculationDomainScopeId, cascadeDelete: true)
                .ForeignKey("dbo.AcfiRatingDomains", t => t.AcfiCalculationDomainId)
                .Index(t => t.AcfiCalculationDomainId)
                .Index(t => t.AcfiCalculationDomainScopeId);
            
            CreateTable(
                "dbo.AcfiCalculationDomainScopes",
                c => new
                    {
                        AcfiCalculationDomainScopeId = c.Int(nullable: false, identity: true),
                        AcfiCalculationDomainScopeDiscriminator = c.Int(nullable: false),
                        AcfiCalculationId = c.Int(nullable: false),
                        Score = c.Decimal(precision: 18, scale: 2),
                        Scope = c.Int(),
                        Level = c.Int(),
                        Funding = c.Decimal(precision: 18, scale: 2),
                        Score2Compare = c.Decimal(precision: 18, scale: 2),
                        Level2Compare = c.Int(),
                    })
                .PrimaryKey(t => t.AcfiCalculationDomainScopeId)
                .ForeignKey("dbo.AcfiCalculations", t => t.AcfiCalculationId, cascadeDelete: true)
                .Index(t => t.AcfiCalculationId);
            
            CreateTable(
                "dbo.AcfiCalculations",
                c => new
                    {
                        AcfiCalculationId = c.Int(nullable: false, identity: true),
                        DateCompleted = c.DateTime(),
                        ReviewDate = c.DateTime(),
                        DateCreated = c.DateTime(nullable: false),
                        AssessorName = c.String(),
                        AssessorProfession = c.String(),
                        ResidentId = c.Int(),
                        CreatedByUserId = c.Int(),
                        TotalFunding = c.Decimal(precision: 18, scale: 2),
                        Level = c.Int(nullable: false),
                        CompletedByUserId = c.Int(),
                        DateDeleted = c.DateTime(),
                        IsReversed = c.Boolean(),
                        AdmissionDate = c.DateTime(),
                        ProviderGivenName = c.String(),
                        ProviderSurname = c.String(),
                        ProviderPosition = c.String(),
                        ProviderPhone = c.String(),
                        RcsSubsidy = c.Decimal(precision: 18, scale: 2),
                        AcfiAppraisalTypeCodeId = c.Int(),
                        FacilityId = c.Int(),
                        AcfiVersion = c.String(),
                        LastSubmissionDate = c.DateTime(),
                        QuickCalc = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AcfiCalculationId);
            
            CreateTable(
                "dbo.AcfiRatingDomains",
                c => new
                    {
                        AcfiCalculationDomainId = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AcfiCalculationDomainId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AcfiCalculationDomains", "AcfiCalculationDomainId", "dbo.AcfiRatingDomains");
            DropForeignKey("dbo.AcfiCalculationDomains", "AcfiCalculationDomainScopeId", "dbo.AcfiCalculationDomainScopes");
            DropForeignKey("dbo.AcfiCalculationDomainScopes", "AcfiCalculationId", "dbo.AcfiCalculations");
            DropForeignKey("dbo.Acfi01CalculationDomain", "AcfiCalculationDomainId", "dbo.AcfiCalculationDomains");
            DropIndex("dbo.AcfiCalculationDomainScopes", new[] { "AcfiCalculationId" });
            DropIndex("dbo.AcfiCalculationDomains", new[] { "AcfiCalculationDomainScopeId" });
            DropIndex("dbo.AcfiCalculationDomains", new[] { "AcfiCalculationDomainId" });
            DropIndex("dbo.Acfi01CalculationDomain", new[] { "AcfiCalculationDomainId" });
            DropTable("dbo.AcfiRatingDomains");
            DropTable("dbo.AcfiCalculations");
            DropTable("dbo.AcfiCalculationDomainScopes");
            DropTable("dbo.AcfiCalculationDomains");
            DropTable("dbo.Acfi01CalculationDomain");
        }
    }
}
