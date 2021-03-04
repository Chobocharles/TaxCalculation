using System.ComponentModel;

namespace IncomeTaxCalculator.TaxObjects
{
    public enum FilingStatus
    {
        [Description("Single")]
        Single = 1,

        [Description("Married")]
        Married = 2,

        [Description("Married Separately")]
        MarriedSeparately = 3,

        [Description("Head of Household")]
        HeadOfHousehold = 4
    }
}