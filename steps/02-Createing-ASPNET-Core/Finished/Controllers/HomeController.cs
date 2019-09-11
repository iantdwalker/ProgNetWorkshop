using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageAnalyse.Models;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace ImageAnalyse.Controllers
{
    public class HomeController : Controller
    {
        // AppSettings
        private readonly AppSettings _appSettings;

        public HomeController(IOptions<AppSettings> appSettings){
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Image Analysis
        public IActionResult ImageAnalysis(){
            return View();
        }

    // Image Analysis (Post)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ImageAnalysis(IFormFile file)
    {
      try {
        var fileToImg = new Repository.FileToImage();

        ViewData["originalImage"] = fileToImg.FileToImgSrcString(file);
        string description;
        string result;
        string confidence;

        using (var httpClient = new HttpClient()){
          string baseUri = _appSettings.VisionApiUri + "/vision/v2.0/describe";

          httpClient.BaseAddress = new Uri(baseUri);
          httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _appSettings.VisionApiKey);
          HttpContent content = new StreamContent(file.OpenReadStream());
          content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

          var response = await httpClient.PostAsync(baseUri, content);

          string jsonResponse = await response.Content.ReadAsStringAsync();

          var jresult = JObject.Parse(jsonResponse);

          description = jresult["description"]["captions"][0]["text"].ToString();
          confidence = jresult["description"]["captions"][0]["confidence"].ToString();
          result = jresult.ToString();
        }

        ViewData["description"] = description;
        ViewData["result"] = result;
        ViewData["confidence"] = confidence;
        
      } catch (Exception ex){
          ViewData["result"] = ex.Message;
      }

      return View();
    }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
