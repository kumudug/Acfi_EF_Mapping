using System.Data.Entity;

namespace AcfiDb
{
    public class AcfiDbContext : DbContext
    {
        public AcfiDbContext() : base("AcfiContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AcfiDbContext>());
        }

        public IDbSet<AcfiCalculation>  AcfiCalculations { get; set; }
        public IDbSet<AcfiCalculationDomainScope> AcfiCalculationDomainScopes { get; set; }
        public IDbSet<AcfiCalculationDomain> AcfiCalculationDomains { get; set; }
        public IDbSet<AcfiRatingDomain> AcfiRatingDomains { get; set; }
        public IDbSet<Acfi01CalculationDomain> Acfi01CalculationDomains { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AcfiCalculationConfiguration());
            modelBuilder.Configurations.Add(new AcfiCalculationDomainScopeConfiguration());
            modelBuilder.Configurations.Add(new AcfiCalculationDomainConfiguration());
            modelBuilder.Configurations.Add(new AcfiRatingDomainConfiguration());
            modelBuilder.Configurations.Add(new Acfi01CalculationDomainConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
