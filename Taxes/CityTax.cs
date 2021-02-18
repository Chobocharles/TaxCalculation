using IncomeTaxCalculator.Enumerations;

namespace IncomeTaxCalculator.Taxes
{
    public class CityTax : StateTax
    {
        public City City { get; set; }

        public string ZipCode { get; set; }

        /// <summary>
        /// The City Tax
        /// </summary>
        /// <param name="taxYear">The year the City Taxes are being calculated for</param>
        /// <param name="state">The State the City resides in</param>
        /// <param name="city">The City we're calculating the taxes for</param>
        /// <param name="zipCode">The Zip Code of the City</param>
        public CityTax(int taxYear, State state, City city, string zipCode) : base(taxYear, state)
        {
            TaxYear = taxYear;
            State = state;
            City = city;
            ZipCode = zipCode;
        }
    }
}