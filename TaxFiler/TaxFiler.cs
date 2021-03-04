using IncomeTaxCalculator.TaxObjects;
using System.Collections.Generic;

namespace IncomeTaxCalculator.TaxFiler
{
    public class TaxFiler
    {
        FilingStatus FilingStatus { get; set; }

        List<Deduction> Deductions { get; set; }

        List<TaxBracket> TaxBrackets { get; set; }

        public TaxFiler(FilingStatus filingStatus, List<Deduction> deductions, List<TaxBracket> taxBrackets)
        {
            this.FilingStatus = filingStatus;
            this.Deductions = deductions;
            this.TaxBrackets = taxBrackets;
        }
    }
}