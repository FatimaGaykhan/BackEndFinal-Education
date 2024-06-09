using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Course;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IWebHostEnvironment _env;

        public CourseController(ICourseService courseService,
                               IWebHostEnvironment env)
        {
            _courseService = courseService;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllForAdminasync();
            return View(courses);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {

            if (id is null) return BadRequest();

            var existCourse = await _courseService.GetByIdWithAllDatasAsync((int)id);

            if (existCourse is null) return NotFound();

            List<CourseImageVM> images = new();

            foreach (var item in existCourse.CourseImages)
            {
                images.Add(new CourseImageVM
                {
                    Image = item.Name,
                    IsMain = item.IsMain
                });
            }

            CourseDetailVM response = new()
            {
                Name = existCourse.Name,
                Price = existCourse.Price.ToString(),
                Category = existCourse.Category.Name,
                Instructor=existCourse.Instructor.FullName,
                StudentCount=existCourse.CourseStudents.Count,
                Rating=existCourse.Rating,
                EndDate=existCourse.EndDate,
                StartDate=existCourse.StartDate,
                Images = images
            };

            return View(response);
        }

        [HttpGet]
        public async Task< IActionResult> Create()
        {
            ViewBag.categories = await _courseService.GetAllSelectedCategoryAsync();
            ViewBag.instructors = await _courseService.GetAllSelectedInstructorAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseCreateVM request)
        {
            ViewBag.categories = await _courseService.GetAllSelectedCategoryAsync();
            ViewBag.instructors = await _courseService.GetAllSelectedInstructorAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var isContainCourse = await _courseService.ExistAsync(request.Name);
            if (isContainCourse)
            {
                ModelState.AddModelError("Name", "This course name already exist");
                return View();
            }

            foreach (var item in request.Images)
            {
                if (!item.CheckFileSize(500))
                {
                    ModelState.AddModelError("Images", "Image size must be 500KB");
                    return View();
                }

                if (!item.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Images", "File type must be only image ");
                    return View();
                }
            }


            List<CourseImage> images = new();

            foreach (var item in request.Images)
            {
                string fileName = $"{Guid.NewGuid()}-{item.FileName}";

                string path = _env.GenerateFilePath("assets/img", fileName);

                await item.SaveFileToLocalAsync(path);

                images.Add(new CourseImage { Name = fileName });
            }

            images.FirstOrDefault().IsMain = true;

            Course course = new()
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                InstructorId=request.InstructorId,
                Rating=request.Rating,
                StartDate=request.StartTime,
                EndDate=request.EndTime,
                Price = decimal.Parse(request.Price.Replace(".", ",")),
                CourseImages = images

            };

            await _courseService.CreateAsync(course);

            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var existCourse = await _courseService.GetByIdWithAllDatasAsync((int)id);

            if (existCourse is null) return NotFound();

            foreach (var item in existCourse.CourseImages)
            {
                string path = _env.GenerateFilePath("assets/img", item.Name);
                path.DeleteFileFromLocal();
            }

            await _courseService.DeleteAsync(existCourse);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.categories = await _courseService.GetAllSelectedCategoryAsync();
            ViewBag.instructors = await _courseService.GetAllSelectedInstructorAsync();

            if (id is null) return BadRequest();

            var existCourse = await _courseService.GetByIdWithAllDatasAsync((int)id);

            if (existCourse is null) return NotFound();

            return View(new CourseEditVM
            {
                Name = existCourse.Name,
                Description = existCourse.Description,
                Price = existCourse.Price.ToString().Replace(",", "."),
                CategoryId = existCourse.CategoryId,
                InstructorId=existCourse.InstructorId,
                EndTime=existCourse.EndDate,
                StartTime=existCourse.StartDate,
                Rating=existCourse.Rating,
                ExistImages = existCourse.CourseImages.Select(m => new CourseImageEditVM
                {
                    Id = m.Id,
                    CourseId = m.CourseId,
                    Image = m.Name,
                    IsMain = m.IsMain
                }).ToList()
            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, CourseEditVM request)
        {
            ViewBag.categories = await _courseService.GetAllSelectedCategoryAsync();
            ViewBag.instructors = await _courseService.GetAllSelectedInstructorAsync();


            if (id is null) return BadRequest();


            var existCourse = await _courseService.GetByIdWithAllDatasAsync((int)id);

            if (existCourse is null) return NotFound();

            if (!ModelState.IsValid)
            {
                request.ExistImages = existCourse.CourseImages.Select(m => new CourseImageEditVM
                {
                    Id = m.Id,
                    CourseId = m.CourseId,
                    Image = m.Name,
                    IsMain = m.IsMain
                }).ToList();

                return View(request);
            }

            if (request.NewImages != null)
            {
                foreach (var item in request.NewImages)
                {
                    if (!item.CheckFileSize(500))
                    {
                        request.ExistImages = existCourse.CourseImages.Select(m => new CourseImageEditVM
                        {
                            Id = m.Id,
                            CourseId = m.CourseId,
                            Image = m.Name,
                            IsMain = m.IsMain
                        }).ToList();


                        ModelState.AddModelError("NewImages", "Image size must be 500KB");
                        return View(request);
                    }

                    if (!item.CheckFileType("image/"))
                    {
                        request.ExistImages = existCourse.CourseImages.Select(m => new CourseImageEditVM
                        {
                            Id = m.Id,
                            CourseId = m.CourseId,
                            Image = m.Name,
                            IsMain = m.IsMain
                        }).ToList();



                        ModelState.AddModelError("NewImages", "File type must be only image ");
                        return View(request);
                    }
                }



            }

            await _courseService.EditAsync(existCourse, request);


            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCourseImage(MainAndDeleteCourseImageVM request)
        {
            await _courseService.DeleteCourseImageAsync(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SetMainImage(MainAndDeleteCourseImageVM request)
        {
            await _courseService.SetMainCourseImageAsync(request);

            return Ok();
        }
    }
}

