using System.ComponentModel;

namespace IncomeTaxCalculator.Enumerations
{
    public class SchoolDistrict
    {
        [Description("Berryville School District")]
        readonly SchoolDistrict Berryville;

        [Description("Green Forest School District")]
        readonly SchoolDistrict GreenForest;

        [Description("Westside School District")]
        readonly SchoolDistrict Westside;

        [Description("Hope School District")]
        readonly SchoolDistrict Hope;

        [Description("Huntsville School District")]
        readonly SchoolDistrict Huntsville;

        [Description("Waldron School District")]
        readonly SchoolDistrict Waldron;

        [Description("Marshall School District")]
        readonly SchoolDistrict Marshall;
    }
}