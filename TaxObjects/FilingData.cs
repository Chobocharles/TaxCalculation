using System.Collections.Generic;
using IncomeTaxCalculator.Statuses;

namespace IncomeTaxCalculator.TaxObjects
{
    public class FilingData
    {
        public string FilingStatus { get; set; }

        public List<FilingStatus> FilingStatuses { get; set; }
    }
}