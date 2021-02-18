using IncomeTaxCalculator.Enumerations;

namespace IncomeTaxCalculator.Taxes
{
    public class StateTax : FederalTax
    {
        public State State { get; set; }

        /// <summary>
        /// The State Tax
        /// </summary>
        /// <param name="taxYear">The year the tax is being calculated for</param>
        /// <param name="state">The state we're calculating the tax for</param>
        public StateTax(int taxYear, State state) : base(taxYear)
        {
            State = state;
            TaxYear = taxYear;
        }
    }
}