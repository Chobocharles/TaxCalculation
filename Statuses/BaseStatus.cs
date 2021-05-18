using System.Collections.Generic;
using IncomeTaxCalculator.TaxObjects;

namespace IncomeTaxCalculator.Statuses
{
    public abstract class BaseStatus
    {
        public List<IncomeTaxBracket> Income_Tax_Bracket { get; set; }

        public List<Deduction> Deductions { get; set; }

        public List<Exemption> Exemptions { get; set; }
    }
}