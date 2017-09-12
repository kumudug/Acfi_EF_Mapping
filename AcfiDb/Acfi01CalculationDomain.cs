namespace AcfiDb
{
    public class Acfi01CalculationDomain
    {
        public int AcfiCalculationDomainId { get; set; }
        public int? Eating { get; set; }
        public int? ReadinessToEat { get; set; }
        public virtual AcfiCalculationDomain AcfiCalculationDomain { get; set; }
    }
}
