using System;

namespace IncomeTaxCalculator.Taxes
{
    public class FederalTax
    {
        public int TaxYear { get; set; }

        public FederalTax()
        {
            TaxYear = DateTime.Now.Year;
        }

        /// <summary>
        /// Federal Tax
        /// </summary>
        /// <param name="taxYear">The year we'll be calculating the Federal Tax for</param>
        public FederalTax(int taxYear)
        {
            TaxYear = taxYear;
        }
    }
}