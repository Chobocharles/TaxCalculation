using IncomeTaxCalculator.Taxes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IncomeTaxCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public async Task<ActionResult> GetFederalTaxes()
        {
            List<FederalTax> FederalTaxes = new List<FederalTax>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Credentials.TaxBaseURL);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(Credentials.FederalTaxesURL);
                    if (response.IsSuccessStatusCode)
                    {
                        var taxResponse = response.Content.ReadAsStringAsync().Result;

                        FederalTaxes = JsonConvert.DeserializeObject<List<FederalTax>>(taxResponse);
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return View(FederalTaxes);
            }
        }
    }
}