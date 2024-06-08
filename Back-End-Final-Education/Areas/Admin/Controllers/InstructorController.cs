using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Instructor;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;
        private readonly IWebHostEnvironment _env;

        public InstructorController(IInstructorService instructorService,
                                    IWebHostEnvironment env)
        {
            _instructorService = instructorService;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var instructor = await _instructorService.GetAllForAdminAsync();

            return View(instructor);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            InstructorDetailVM instructor = await _instructorService.DetailAsync((int)id);

            if (instructor is null) return NotFound();


            return View(instructor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InstructorCreateVM request)
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

            await _instructorService.CreateAsync(new Instructor { FullName = request.FullName, Position = request.Position, Image = fileName });

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var instructor = await _instructorService.GetByIdAsync((int)id);

            if (instructor is null) return NotFound();

            string path = _env.GenerateFilePath("assets/img", instructor.Image);

            path.DeleteFileFromLocal();

            await _instructorService.DeleteAsync(instructor);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> AddSocial(int? id)
        {
            ViewBag.socialMedias = await _instructorService.GetAllSelectedAsync();

            if (id is null) return BadRequest();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSocial(int? id,InstructorSocialMediaVM request)
        {
            ViewBag.socialMedias = await _instructorService.GetAllSelectedAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id is null) return BadRequest();

            if (await _instructorService.ExistExceptByIdAsync((int)id, request.Link))
            {
                ModelState.AddModelError("Link", "This link already exist");
                return View();
            }

            var instructor = await _instructorService.GetByIdAsync((int)id);

            if (instructor is null) return NotFound();

            await _instructorService.AddSocialAsync(new InstructorSocialMedia { SocialMediaId = request.SocialMediaId, InstructorId=instructor.Id,SocialLink=request.Link});

            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            //ViewBag.instructorSocialMedias = await _instructorService.GetAllSelectedByLinkAsync((int)id);

            if (id is null) return BadRequest();

            var instructor= await _instructorService.GetByIdAsync((int)id);



            if (instructor is null) return NotFound();


            return View(new InstructorEditVM { FullName = instructor.FullName, Position = instructor.Position, Image = instructor.Image,SocialMediaLinks=instructor.InstructorSocialMedias.Select(m=>new InstructorSocialMediaLinkVM { IntroductId=m.InstructorId,Link=m.SocialLink,SocialId=m.SocialMediaId}).ToList() });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,InstructorEditVM request)
        {
            if (!ModelState.IsValid)
            {

                var existInstructor = await _instructorService.GetByIdAsync((int)id);


                return View(new InstructorEditVM { Image = existInstructor.Image });
            }

            if (id is null) return BadRequest();

            var instructor = await _instructorService.GetByIdAsync((int)id);

            if (instructor is null) return NotFound();

            if (request.NewImage != null)
            {
                if (!request.NewImage.CheckFileType("image/"))
                {
                    ModelState.AddModelError("NewImage", "Input can accept only image format");
                    request.Image = instructor.Image;
                    return View(request);
                }

                if (!request.NewImage.CheckFileSize(200))
                {
                    ModelState.AddModelError("NewImage", "Image size  must be max 200KB");
                    request.Image = instructor.Image;
                    return View(request);
                }

                string oldPath = _env.GenerateFilePath("assets/img", instructor.Image);

                oldPath.DeleteFileFromLocal();

                string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;


                string newPath = _env.GenerateFilePath("assets/img", fileName);

                await request.NewImage.SaveFileToLocalAsync(newPath);

                instructor.Image = fileName;

            }

            await _instructorService.EditAsync(instructor, request);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSocialMediaLink(InstructorSocialLinkDeleteVM request)
        {
            await _instructorService.DeleteSocialLinkAsync(request);

            return Ok();
        }
    }
}

