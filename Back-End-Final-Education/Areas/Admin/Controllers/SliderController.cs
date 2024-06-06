using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IWebHostEnvironment _env;

        public SliderController(ISliderService sliderService,
                                IWebHostEnvironment env)
        {
            _sliderService = sliderService;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderVM> sliders = await _sliderService.GetAllForAdminAsync();


            return View(sliders);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            SliderDetailVM slider = await _sliderService.DetailAsync((int) id);

            if (slider is null) return NotFound();


            return View(slider);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool existSlider = await _sliderService.ExistAsync(request.Title);
            if (existSlider)
            {
                ModelState.AddModelError("Title", "This slider title already exist");

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

            await _sliderService.CreateAsync(new Slider { Title = request.Title, Description = request.Description,Subject=request.Subject, Image = fileName });

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int?id)
        {
            if (id is null) return BadRequest();

            var slider = await _sliderService.GetByIdAsync((int)id);

            if (slider is null) return NotFound();

            string path = _env.GenerateFilePath("assets/img", slider.Image);

            path.DeleteFileFromLocal();

            await _sliderService.DeleteAsync(slider);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            var slider = await _sliderService.GetByIdAsync((int)id);

            if (slider is null) return NotFound();

            return View(new SliderEditVM { Title = slider.Title, Description = slider.Description,Subject=slider.Subject, Image = slider.Image });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SliderEditVM request,int? id)
        {
            if (!ModelState.IsValid)
            {

                var existSlider = await _sliderService.GetByIdAsync((int)id);


                return View(new SliderEditVM { Image = existSlider.Image });
            }


            if (id is null) return BadRequest();

            if (await _sliderService.ExistExceptByIdAsync((int)id, request.Title))
            {
                ModelState.AddModelError("Title", "This slider title already exist");
                return View();
            }

            var slider= await _sliderService.GetByIdAsync((int)id);

            if (slider is null) return NotFound();

            if (request.NewImage != null)
            {
                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Input can accept only image format");
                    request.Image = slider.Image;
                    return View(request);
                }

                if (!request.NewImage.CheckFileSize(200))
                {
                    ModelState.AddModelError("NewImage", "Image size  must be max 200KB");
                    request.Image = slider.Image;
                    return View(request);
                }

                string oldPath = _env.GenerateFilePath("assets/img", slider.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;


                string newPath = _env.GenerateFilePath("assets/img", fileName);

                await request.NewImage.SaveFileToLocalAsync(newPath);

                slider.Image = fileName;

            }


            await _sliderService.EditAsync(slider, request);

            return RedirectToAction(nameof(Index));
        }
    }
}

