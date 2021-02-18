using IncomeTaxCalculator.Enumerations;

namespace IncomeTaxCalculator.Taxes
{
    public class CountyTax : StateTax
    {
        public City City { get; set; }

        public County County { get; set; }

        public string ZipCode { get; set; }

        /// <summary>
        /// The County Tax
        /// </summary>
        /// <param name="taxYear">The year we're calculating the County Tax for</param>
        /// <param name="state">The State that the County resides in</param>
        /// <param name="city">The City that resides within the County</param>
        /// <param name="zipCode">The Zip Code of the City</param>
        /// <param name="county">The County we're calculating the tax for</param>
        public CountyTax(int taxYear, State state, City city, string zipCode, County county): base(taxYear, state)
        {
            TaxYear = taxYear;
            State = state;
            City = city;
            ZipCode = zipCode;
            County = county;
        }
    }
}