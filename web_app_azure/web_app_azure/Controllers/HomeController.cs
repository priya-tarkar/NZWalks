using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using web_app_azure.Models;

namespace web_app_azure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile f,String folder)
        {
            string source = f.FileName;
            source = Path.GetFileName(source);
            string p = "C:\\udemy\\code\\NZWalks\\web_app_azure\\web_app_azure\\wwwroot\\" + folder;
            string p1 = "C:\\udemy\\code\\NZWalks\\web_app_azure\\web_app_azure\\wwwroot\\";
            string file_path = Path.Combine(p, source);
            Directory.CreateDirectory(p);
            var stream = new FileStream(file_path, FileMode.Create);
            f.CopyToAsync(stream);
            stream.Close();
            Console.WriteLine(file_path);
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=commercesite;AccountKey=FixqrCnwe4CViCMTL5sfMc3lcQdWg6Wqajr9LkeKZrBe1wImMC9mIJOKqi/6OIa1zppw638UBnal+AStXkKb3g==;EndpointSuffix=core.windows.net";
            string containerName = "imagecheck";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);
            var filePathOverCloud = file_path.Replace(p1, string.Empty);
            MemoryStream str = new MemoryStream(System.IO.File.ReadAllBytes(file_path));


            //Console.WriteLine(blob.Name);
            //Console.WriteLine(filePathOverCloud);

            containerClient.UploadBlob(filePathOverCloud, str);


            str.Close();
            //System.IO.File.Delete(file_path);
            Directory.Delete(p, true);
            return Content(filePathOverCloud + "Uploaded");
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