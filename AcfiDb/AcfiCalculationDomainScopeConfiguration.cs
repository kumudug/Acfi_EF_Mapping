using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AcfiDb
{
    public class AcfiCalculationDomainScopeConfiguration : EntityTypeConfiguration<AcfiCalculationDomainScope>
    {
        public AcfiCalculationDomainScopeConfiguration()
        {
            HasKey(t => t.AcfiCalculationDomainScopeId);
            Property(t => t.AcfiCalculationDomainScopeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired<AcfiCalculation>(s => s.AcfiCalculation).WithMany(s => s.AcfiCalculationDomainScopes).HasForeignKey(x => x.AcfiCalculationId);
        }
    }
}
