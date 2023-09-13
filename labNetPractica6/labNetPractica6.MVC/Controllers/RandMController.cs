using labNetPracica7.API.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace labNetPracica7.API.Controllers
{
    public class RandMController : Controller
    {
        private readonly HttpClient client = new HttpClient();

        public RandMController() 
        {
            client.BaseAddress = new Uri("https://rickandmortyapi.com/api/character");
        }
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ResponseRick>(json);
                return View(data.results);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
