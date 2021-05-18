namespace IncomeTaxCalculator.TaxObjects
{
    public class IncomeTaxBracket
    {
        public int Bracket { get; set; }

        public decimal Marginal_Rate { get; set; }

        public decimal Marginal_Capital_Gain_Rate { get; set; }

        public double Amount { get; set; }
    }
}