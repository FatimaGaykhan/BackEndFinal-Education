using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Categories;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _env;

        public CategoryController(ICategoryService categoryService,
                                 IWebHostEnvironment env)
        {
            _categoryService = categoryService;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryVM> categories = await _categoryService.GetAllForAdminAsync();

            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            CategoryDetailVM category = await _categoryService.DetailAsync((int)id);

            if (category is null) return NotFound();

            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool existCategory = await _categoryService.ExistAsync(request.Name);

            if (existCategory)
            {
                ModelState.AddModelError("Name", "This category name already exist");

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

            await _categoryService.CreateAsync(new Category { Name = request.Name, Image = fileName });

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {

            if (id is null) return BadRequest();

            var category = await _categoryService.GetByIdAsync((int)id);

            if (category is null) return NotFound();

            string path = _env.GenerateFilePath("assets/img", category.Image);

            path.DeleteFileFromLocal();

            await _categoryService.DeleteAsync(category);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            var category = await _categoryService.GetByIdAsync((int)id);

            if (category is null) return NotFound();

            return View(new CategoryEditVM { Name = category.Name, Image = category.Image });

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,CategoryEditVM request)
        {
            if (!ModelState.IsValid)
            {

                var existCategory = await _categoryService.GetByIdAsync((int)id);


                return View(new CategoryEditVM { Image = existCategory.Image });
            }


            if (id is null) return BadRequest();

            if (await _categoryService.ExistExceptByIdAsync((int)id, request.Name))
            {
                ModelState.AddModelError("Name", "This category name already exist");
                return View();
            }

            var category = await _categoryService.GetByIdAsync((int)id);

            if (category is null) return NotFound();

            if (request.NewImage != null)
            {
                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Input can accept only image format");
                    request.Image = category.Image;
                    return View(request);
                }

                if (!request.NewImage.CheckFileSize(200))
                {
                    ModelState.AddModelError("NewImage", "Image size  must be max 200KB");
                    request.Image = category.Image;
                    return View(request);
                }

                string oldPath = _env.GenerateFilePath("assets/img", category.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;


                string newPath = _env.GenerateFilePath("assets/img", fileName);

                await request.NewImage.SaveFileToLocalAsync(newPath);

                category.Image = fileName;

            }

            await _categoryService.EditAsync(category, request);

            return RedirectToAction(nameof(Index));

        }

    }
}

