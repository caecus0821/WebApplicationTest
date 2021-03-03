using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApplicationTest.Models;


namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<CustomerViewModel> custobj = null;

            HttpClient client = new HttpClient();

            //clientkey provided
            string clientKey = "2525df56477f58e5868c240ee5228b0b5d4367c4";

            //api url
            client.BaseAddress = new Uri("https://api.bigcommerce.com/stores/store_hash/v3/customers");
            client.DefaultRequestHeaders.Add("X-Auth-Token", clientKey);

            var apicustomercont = client.GetAsync("customers");
            apicustomercont.Wait();

            var result = apicustomercont.Result;

            if (result.IsSuccessStatusCode)
            {
                var custtable = result.Content.ReadAsAsync<IList<CustomerViewModel>>();
                custtable.Wait();
                custobj = custtable.Result;
            }

            else
            {
                custobj = Enumerable.Empty<CustomerViewModel>();
                ModelState.AddModelError(string.Empty, "Error loading data");
            }


            return View(custobj);
        }




        public ActionResult Contact()
        {
            IEnumerable<CustoDetViewModel> custDetobj = null;

            HttpClient client = new HttpClient();
            string clientKey = "2525df56477f58e5868c240ee5228b0b5d4367c4";

            client.BaseAddress = new Uri("https://api.bigcommerce.com/stores/store_hash/v3/customers");
            client.DefaultRequestHeaders.Add("X-Auth-Token", clientKey);

            var apicustomercont = client.GetAsync("customers");
            apicustomercont.Wait();

            var result = apicustomercont.Result;

            if (result.IsSuccessStatusCode)
            {
                var custdettable = result.Content.ReadAsAsync<IList<CustoDetViewModel>>();
                custdettable.Wait();
                custDetobj = custdettable.Result;
            }

            else
            {
                custDetobj = Enumerable.Empty<CustoDetViewModel>();
                ModelState.AddModelError(string.Empty, "Error loading data");
            }


            return View(custDetobj);
        }


    }




}
