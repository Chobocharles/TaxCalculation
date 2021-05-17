using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IncomeTaxCalculator.TaxFilers
{
    public class SingleFiler
    {
        public string IncomeTaxBracket { get; set; }

        public string Deductions { get; set; }

        public string Exemptions { get; set; }
    }
}