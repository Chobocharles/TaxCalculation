using IncomeTaxCalculator.Statuses;
using IncomeTaxCalculator.TaxObjects;
using System.Collections.Generic;

namespace IncomeTaxCalculator.TaxFilerObject
{
    public class TaxFiler
    {
        FilingStatus FilingStatus { get; set; }

        List<IncomeTaxBracket> TaxBrackets { get; set; }

        List<Deduction> Deductions { get; set; }

        List<Exemption> Exemptions { get; set; }

        public TaxFiler(FilingStatus filingStatus, List<Deduction> deductions, List<IncomeTaxBracket> taxBrackets)
        {
            this.FilingStatus = filingStatus;
            this.Deductions = deductions;
            this.TaxBrackets = taxBrackets;
        }
    }
}