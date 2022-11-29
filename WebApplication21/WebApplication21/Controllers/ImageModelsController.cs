using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    public class ImageModelsController : Controller
    {
        private readonly ImageDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ImageModelsController(ImageDbContext context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: ImageModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.images.ToListAsync());
        }

        // GET: ImageModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.images == null)
            {
                return NotFound();
            }

            var imageModel = await _context.images
                .FirstOrDefaultAsync(m => m.imageId == id);
            if (imageModel == null)
            {
                return NotFound();
            }

            return View(imageModel);
        }

        // GET: ImageModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImageModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("imageId,title,ImageFile")] ImageModel imageModel)
        {
            if (ModelState.IsValid)
            {
                /* string wwwRootPath = _hostEnvironment.WebRootPath;
                 string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
                 string extension = Path.GetExtension(imageModel.ImageFile.FileName);
                 imageModel.ImageName = fileName  ;
                 string path = Path.Combine(wwwRootPath + "/Image", fileName);*/

                string connectionstring = "DefaultEndpointsProtocol=https;AccountName=priyacheck;AccountKey=ZYkTWtYrsPFU4hj+dvNoo36fJvP1gmWMk+6g4fgVGOSDOkRru3wixC6f4OT+FmBpx0X7tZkh4rXh+ASt724ZCA==;EndpointSuffix=core.windows.net";
                string container = "add";
                BlobContainerClient containerClient = new BlobContainerClient(connectionstring, container);
                BlobClient blobClient = containerClient.GetBlobClient(imageModel.ImageFile.FileName);
                MemoryStream ms = new MemoryStream();
                imageModel.ImageFile.CopyToAsync(ms);
                ms.Position = 0;
                blobClient.UploadAsync(ms);
                imageModel.ImageName = blobClient.Uri.AbsoluteUri;
                //string path=Path.Combine()
                _context.Add(imageModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imageModel);
        }

        // GET: ImageModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.images == null)
            {
                return NotFound();
            }

            var imageModel = await _context.images.FindAsync(id);
            if (imageModel == null)
            {
                return NotFound();
            }
            return View(imageModel);
        }

        // POST: ImageModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("imageId,title,ImageName")] ImageModel imageModel)
        {
            if (id != imageModel.imageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imageModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImageModelExists(imageModel.imageId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(imageModel);
        }

        // GET: ImageModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.images == null)
            {
                return NotFound();
            }

            var imageModel = await _context.images
                .FirstOrDefaultAsync(m => m.imageId == id);
            if (imageModel == null)
            {
                return NotFound();
            }

            return View(imageModel);
        }

        // POST: ImageModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.images == null)
            {
                return Problem("Entity set 'ImageDbContext.images'  is null.");
            }
            var imageModel = await _context.images.FindAsync(id);
            if (imageModel != null)
            {
                _context.images.Remove(imageModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImageModelExists(int id)
        {
          return _context.images.Any(e => e.imageId == id);
        }
    }
}
