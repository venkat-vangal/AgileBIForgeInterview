using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AgileBIForgeInterview.Controllers
{
    public class HomeController : Controller
    {
        //Hosted web API REST Service base url  
        string BaseUrl = ConfigurationManager.AppSettings["BaseAddress"];
        public async Task<ActionResult> Index()
        {

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(BaseUrl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Log Making Api Call

                DateTime dateTime = DateTime.MinValue;

                //Sending request to find web api REST service resource  using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Date");
                try
                {
                    //Checking the response is successful or not which is sent using HttpClient  
                    if (Res.IsSuccessStatusCode)
                    {
                        //Log Success
                        //Storing the response details recieved from web api   
                        var response = Res.Content.ReadAsStringAsync().Result;
                        dateTime  = JsonConvert.DeserializeObject<DateTime>(response);
                    }
                }
                catch (HttpRequestException requestException)
                {
                    //Log Exception
                    throw requestException;
                }
                catch (ArgumentNullException argumentNullException)
                {
                    //Log Exception
                    throw argumentNullException;
                }
                catch(Exception)
                {
                    throw new Exception("Error occured while retrieving the DateTime");
                }

                return View(dateTime);
            }
        }
    }
}
