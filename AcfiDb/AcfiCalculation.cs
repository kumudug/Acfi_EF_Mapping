using System;
using System.Collections.Generic;

namespace AcfiDb
{
    public class AcfiCalculation
    {
        public int AcfiCalculationId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? ReviewDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string AssessorName { get; set; }
        public string AssessorProfession { get; set; }
        public int? ResidentId { get; set; }
        public int? CreatedByUserId { get; set; }
        public decimal? TotalFunding { get; set; }
        public int Level { get; set; }
        public int? CompletedByUserId { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool? IsReversed { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string ProviderGivenName { get; set; }
        public string ProviderSurname { get; set; }
        public string ProviderPosition { get; set; }
        public string ProviderPhone { get; set; }
        public decimal? RcsSubsidy { get; set; }
        public int? AcfiAppraisalTypeCodeId { get; set; }
        public int? FacilityId { get; set; }
        public string AcfiVersion { get; set; }
        public DateTime? LastSubmissionDate { get; set; }
        public bool QuickCalc { get; set; }

        public virtual ICollection<AcfiCalculationDomainScope> AcfiCalculationDomainScopes { get; set; }
    }
}
