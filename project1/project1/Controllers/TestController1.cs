using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using project1.Models;
using static NuGet.Packaging.PackagingConstants;

namespace project1.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
            using(photocheckContext photo=new photocheckContext())
            {
                return View(photo.Datachecks.ToList());
            }
            
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormFile f,string folder,Datacheck data1)
        {
            string source = f.FileName;
            source = Path.GetFileName(source);
            string p = "C:\\Users\\AditiGarg\\source\\repos\\Azure_Upload\\Azure_Upload\\wwwroot\\" + folder;
            string p1 = "C:\\Users\\AditiGarg\\source\\repos\\Azure_Upload\\Azure_Upload\\wwwroot\\";
            string file_path = Path.Combine(p, source);
            
            using(photocheckContext photo=new photocheckContext())
            {
                photo.Datachecks.Add(data1);
                photo.SaveChanges();

            }
            Directory.CreateDirectory(p);
            var stream = new FileStream(file_path, FileMode.Create);
            f.CopyToAsync(stream);
            stream.Close();
            Console.WriteLine(file_path);
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=taskmgi;AccountKey=tuJIS7vmEmFmfkS2PXsVXL3vECCPx0nfJEieWpHZYz9k+Uc+kqcsUHQAj+hDp3nqq62Pp9Z22tRZ+AStggzgvg==;EndpointSuffix=core.windows.net";
            string containerName = "development";
            BlobContainerClient containerClient = new BlobContainerClient(connectionString, containerName);
            var filePathOverCloud = file_path.Replace(p1, string.Empty);
            MemoryStream str = new MemoryStream(System.IO.File.ReadAllBytes(file_path));


            //Console.WriteLine(blob.Name);
            //Console.WriteLine(filePathOverCloud);

            containerClient.UploadBlob(filePathOverCloud, str);
            data1.Image = file_path;


            str.Close();
            //System.IO.File.Delete(file_path);
            Directory.Delete(p, true);
            return Content(filePathOverCloud + "Uploaded");
        }

        

            
        }

    }
    

