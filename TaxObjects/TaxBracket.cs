namespace IncomeTaxCalculator.TaxObjects
{
    public class TaxBracket
    {
        int Rate { get; set; }

        decimal MinimumIncome { get; set; }

        decimal MaximumIncome { get; set; }
    }
}