namespace AcfiDb
{
    public class AcfiCalculationDomain
    {
        public int AcfiCalculationDomainId { get; set; }
        public int AcfiCalculationDomainScopeId { get; set; }
        public int AcfiDomainId { get; set; }
        public bool IsViewed { get; set; }

        public virtual AcfiCalculationDomainScope AcfiCalculationDomainScope { get; set; }
        public virtual AcfiRatingDomain AcfiRatingDomain { get; set; }
        public virtual Acfi01CalculationDomain Acfi01CalculationDomain { get; set; }
    }
}
