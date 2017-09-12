using System.Data.Entity.ModelConfiguration;

namespace AcfiDb
{
    public class AcfiRatingDomainConfiguration : EntityTypeConfiguration<AcfiRatingDomain>
    {
        public AcfiRatingDomainConfiguration()
        {
            HasKey(t => t.AcfiCalculationDomainId);
            HasRequired(s => s.AcfiCalculationDomain).WithRequiredPrincipal(s => s.AcfiRatingDomain);
        }
    }
}
