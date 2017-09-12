using System.Collections.Generic;

namespace AcfiDb
{
    public class AcfiCalculationDomainScope
    {
        public int AcfiCalculationDomainScopeId { get; set; }
        public int AcfiCalculationDomainScopeDiscriminator { get; set; }
        public int AcfiCalculationId { get; set; }
        public decimal? Score { get; set; }
        public int? Scope { get; set; }
        public int? Level { get; set; }
        public decimal? Funding { get; set; }
        public decimal? Score2Compare { get; set; }
        public int? Level2Compare { get; set; }

        public virtual AcfiCalculation AcfiCalculation { get; set; }

        public virtual ICollection<AcfiCalculationDomain> AcfiCalculationDomains { get; set; }
    }
}
