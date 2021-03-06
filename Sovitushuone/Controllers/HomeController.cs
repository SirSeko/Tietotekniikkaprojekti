using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sovitushuone.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sovitushuone.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlobService _blobService;
       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IBlobService blobService)
        {
            _logger = logger;
            _blobService = blobService;
        }
        //Testataan blobien hakua azuresta
        [HttpGet("{blobName}")]

        public async Task<IActionResult> GetBlobAsync(string blobName)
        {
           
            var data = await  _blobService.GetBlobAsync(blobName);
            
            return View();
        }
        //Testataan blobien hakua azuresta listaan
        [HttpGet("list")]
        public async Task<IActionResult> ListBlobs()

        {
            return Ok(await _blobService.ListBlobsAsync());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
