using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AcfiDb
{
    public class AcfiCalculationConfiguration : EntityTypeConfiguration<AcfiCalculation>
    {
        public AcfiCalculationConfiguration()
        {
            HasKey(t => t.AcfiCalculationId);
            Property(t => t.AcfiCalculationId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
