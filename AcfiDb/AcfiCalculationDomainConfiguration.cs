using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AcfiDb
{
    public class AcfiCalculationDomainConfiguration : EntityTypeConfiguration<AcfiCalculationDomain>
    {
        public AcfiCalculationDomainConfiguration()
        {
            HasKey(t => t.AcfiCalculationDomainId);
            Property(t => t.AcfiCalculationDomainId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired<AcfiCalculationDomainScope>(s => s.AcfiCalculationDomainScope).WithMany(s => s.AcfiCalculationDomains).HasForeignKey(x => x.AcfiCalculationDomainScopeId);
            HasOptional(s => s.Acfi01CalculationDomain).WithRequired(s => s.AcfiCalculationDomain);
        }
    }
}
