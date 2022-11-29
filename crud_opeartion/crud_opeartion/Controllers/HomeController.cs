using Azure.Storage.Blobs;
using crud_opeartion.DataDB;
using crud_opeartion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crud_opeartion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        EcommerceContext _context = new EcommerceContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var l = _context.Categories.ToList();
            return View(l);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Category model)
        {
            String connectionString = @"FixqrCnwe4CViCMTL5sfMc3lcQdWg6Wqajr9LkeKZrBe1wImMC9mIJOKqi/6OIa1zppw638UBnal+AStXkKb3g==";
            String containername = "imagecheck";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containername);
            BlobClient blobClient = containerClient.GetBlobClient(model.Imageurl.FileName);
            MemoryStream ms = new MemoryStream();
            model.Imageurl.CopyToAsync(ms);
            ms.Position = 0;
            blobClient.UploadAsync(ms);
            _context.Categories.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "data inserted succeessfully";
            return View();

        }

       /* public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}