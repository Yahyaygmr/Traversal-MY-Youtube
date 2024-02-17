using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using System.Net.Http.Headers;
using TraversalCore.Areas.Admin.Models;
using Newtonsoft.Json;

namespace TraversalCore.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/ApiMovie")]
    public class ApiMovieController : Controller
    {
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovieList = new List<ApiMovieViewModel>();

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "b23f98432bmsh73554435a557e74p132c7fjsnf1ce1fb2aa23" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovieList = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(apiMovieList);
            }
            
        }
    }
}
