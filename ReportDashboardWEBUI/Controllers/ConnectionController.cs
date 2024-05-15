using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using ReportDashboard.DtoLayer.DbTableDto;
using Newtonsoft.Json;
using System.Text;

namespace ReportDashboardWEBUI.Controllers
{
    public class ConnectionController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ConnectionController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateDbTableDto dbTableDto)
        {
            if (!ModelState.IsValid)
            {
                // Eğer model geçerli değilse, formu tekrar göster ve hataları kullanıcıya göster
                return View(dbTableDto);
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dbTableDto);
            Console.WriteLine(jsonData);  

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7097/api/DbTable/CreateDbTable", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            var errorMessage = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(errorMessage);  // Hata mesajını konsola yazdır

            // Eğer istek başarısız olursa, formu tekrar göster ve hatayı kullanıcıya göster
            ModelState.AddModelError(string.Empty, "Bir hata oluştu: " + errorMessage);
            return View(dbTableDto);
        }
        public async Task<IActionResult> ConnectionList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7097/api/DbTable/DbTableList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDbTableDto>>(jsonData);
                return View(values);
            }
            return View();
        }

    }
}
