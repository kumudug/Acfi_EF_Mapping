namespace AcfiDb
{
    public class AcfiRatingDomain
    {
        public int AcfiCalculationDomainId { get; set; }
        public int Rating { get; set; }
        public virtual AcfiCalculationDomain AcfiCalculationDomain { get; set; }
    }
}
