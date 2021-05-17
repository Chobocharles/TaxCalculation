using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using IncomeTaxCalculator.Models;
using IncomeTaxCalculator.Statuses;
using Newtonsoft.Json;

namespace IncomeTaxCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly HomeModel homeModel = new HomeModel();
        public ActionResult Index()
        {
            return View(homeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetFederalTaxes()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Credentials.TestURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.TaxAPIKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(Credentials.TestURL);
                    if (response.IsSuccessStatusCode)
                    {
                        var taxResponse = response.Content.ReadAsStringAsync().Result;

                        FilingStatus filingStatus = (FilingStatus)JsonConvert.DeserializeObject(taxResponse, typeof(FilingStatus));
                        homeModel.FilingStatus = filingStatus.Head_of_Household.Deductions[0].Deduction_Amount.ToString();
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return View("Index", homeModel);
            }
        }
    }
}