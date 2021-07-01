
namespace IncomeTaxCalculator.Models
{
    using System.ComponentModel.DataAnnotations;

    public class HomeModel
    {
        public string FilingStatus { get; set; }

        public string FederalOrState { get; set; }

        [Required]
        public int? FilingYear { get; set; }

        public string BaseAddress => $"{Credentials.BaseURL}/{FederalOrState}/{FilingYear}";
    }
}