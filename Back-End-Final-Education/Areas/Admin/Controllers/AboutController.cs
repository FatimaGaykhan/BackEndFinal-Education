using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Abouts;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IWebHostEnvironment _env;

        public AboutController(IAboutService aboutService,
                              IWebHostEnvironment env)
        {
            _aboutService = aboutService;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var abouts =await _aboutService.GetAllForAdminAsync();

            return View(abouts);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            AboutDetailVM about = await _aboutService.DetailAsync((int)id);

            if (about is null) return NotFound();


            return View(about);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!request.Image.CheckFileType("image/"))
            {
                ModelState.AddModelError("Image", "Input can accept only image format");
                return View();
            }

            if (!request.Image.CheckFileSize(200))
            {
                ModelState.AddModelError("Image", "Image size  must be max 200KB");
                return View();
            }

            string fileName = Guid.NewGuid().ToString() + "-" + request.Image.FileName;

            string path = _env.GenerateFilePath("assets/img", fileName);

            await request.Image.SaveFileToLocalAsync(path);

            await _aboutService.CreateAsync(new About { Title = request.Title, Description = request.Description, Image = fileName });

            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var about = await _aboutService.GetByIdAsync((int)id);

            if (about is null) return NotFound();

            string path = _env.GenerateFilePath("assets/img", about.Image);

            path.DeleteFileFromLocal();

            await _aboutService.DeleteAsync(about);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            var about = await _aboutService.GetByIdAsync((int)id);

            if (about is null) return NotFound();

            return View(new AboutEditVM { Title = about.Title, Description = about.Description, Image = about.Image });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AboutEditVM request, int? id)
        {
            if (!ModelState.IsValid)
            {

                var existAbout = await _aboutService.GetByIdAsync((int)id);

                return View(new AboutEditVM { Image = existAbout.Image });
            }

            if (id is null) return BadRequest();

            var about = await _aboutService.GetByIdAsync((int)id);

            if (about is null) return NotFound();

            if (request.NewImage != null)
            {
                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Input can accept only image format");
                    request.Image = about.Image;
                    return View(request);
                }

                if (!request.NewImage.CheckFileSize(200))
                {
                    ModelState.AddModelError("NewImage", "Image size  must be max 200KB");
                    request.Image = about.Image;
                    return View(request);
                }

                string oldPath = _env.GenerateFilePath("assets/img", about.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;

                string newPath = _env.GenerateFilePath("assets/img", fileName);

                await request.NewImage.SaveFileToLocalAsync(newPath);

                about.Image = fileName;


            }

            await _aboutService.EditAsync(about, request);

            return RedirectToAction(nameof(Index));
        }
    }
}

