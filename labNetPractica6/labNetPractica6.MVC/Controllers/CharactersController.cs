using labNetPractica6.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace labNetPractica6.MVC.Controllers
{
    public class CharactersController : Controller
    {
        private readonly HttpClient client;
        // GET: Characters

        public CharactersController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://rickandmortyapi.com/api/character/");
        }
        public async Task <ActionResult> Index()
        {
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<CharacterResponse>(json);

                return View(data.results);
            }
            else
            {
                return View("Error");
            }
        }
    }
}