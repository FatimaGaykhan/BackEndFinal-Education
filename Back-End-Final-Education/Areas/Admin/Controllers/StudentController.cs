using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Slider;
using Back_End_Final_Education.ViewModels.Students;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IWebHostEnvironment _env;

        public StudentController(IStudentService studentService,
                                IWebHostEnvironment env)
        {
            _studentService = studentService;
            _env = env;
        }

        public async Task< IActionResult> Index()
        {
            IEnumerable<StudentVM> students = await _studentService.GetAllForAdminasync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            StudentDetailVM student = await _studentService.DetailAsync((int)id);

            if (student is null) return NotFound();


            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentCreateVM request)
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

            await _studentService.CreateAsync(new Student { FullName = request.FullName, Description = request.Description, Profession = request.Profession, Image = fileName });

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var student = await _studentService.GetByIdAsync((int)id);

            if (student is null) return NotFound();

            string path = _env.GenerateFilePath("assets/img", student.Image);

            path.DeleteFileFromLocal();

            await _studentService.DeleteAsync(student);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            
                if (id is null) return BadRequest();

                var student = await _studentService.GetByIdAsync((int)id);

                if (student is null) return NotFound();

                return View(new StudentEditVM {  FullName=student.FullName, Description = student.Description, Profession= student.Profession, Image = student.Image });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, StudentEditVM request)
        {
            if (!ModelState.IsValid)
            {

                var existStudent = await _studentService.GetByIdAsync((int)id);


                return View(new StudentEditVM { Image = existStudent.Image });
            }


            if (id is null) return BadRequest();

            var student = await _studentService.GetByIdAsync((int)id);

            if (student is null) return NotFound();

            if (request.NewImage != null)
            {
                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Input can accept only image format");
                    request.Image = student.Image;
                    return View(request);
                }

                if (!request.NewImage.CheckFileSize(200))
                {
                    ModelState.AddModelError("NewImage", "Image size  must be max 200KB");
                    request.Image = student.Image;
                    return View(request);
                }

                string oldPath = _env.GenerateFilePath("assets/img", student.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;


                string newPath = _env.GenerateFilePath("assets/img", fileName);

                await request.NewImage.SaveFileToLocalAsync(newPath);

                student.Image = fileName;

            }

            await _studentService.EditAsync(student, request);

            return RedirectToAction(nameof(Index));
        }
    }
}

