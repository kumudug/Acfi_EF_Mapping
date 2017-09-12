using System.Data.Entity.ModelConfiguration;

namespace AcfiDb
{
    public class Acfi01CalculationDomainConfiguration : EntityTypeConfiguration<Acfi01CalculationDomain>
    {
        public Acfi01CalculationDomainConfiguration()
        {
            HasKey(t => t.AcfiCalculationDomainId);
            HasRequired(s => s.AcfiCalculationDomain).WithRequiredPrincipal(s => s.Acfi01CalculationDomain);
        }
    }
}
