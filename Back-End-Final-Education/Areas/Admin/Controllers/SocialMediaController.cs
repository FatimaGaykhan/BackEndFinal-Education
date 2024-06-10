using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Course;
using Back_End_Final_Education.ViewModels.SocialMedia;
using Back_End_Final_Education.ViewModels.Students;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {

        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;

        }

        public async Task< IActionResult> Index()
        {
            IEnumerable<SocialMediaVM> socialMedias = await _socialMediaService.GetAllAsync();
            return View(socialMedias);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            SocialMediaDetailVM socialMedia = await _socialMediaService.DetailAsync((int)id);

            if (socialMedia is null) return NotFound();


            return View(socialMedia);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SocialMediaCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _socialMediaService.CreateAsync(new SocialMedia { Icon = request.Icon, Name = request.Name });

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var socialMedia = await _socialMediaService.GetByIdAsync((int)id);

            if (socialMedia is null) return NotFound();


            await _socialMediaService.DeleteAsync(socialMedia);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.socials = await _socialMediaService.GetAllSelectedSocialMediaAsync();

            if (id is null) return BadRequest();

            var existSocial = await _socialMediaService.GetByIdAsync((int)id);

            if (existSocial is null) return NotFound();

            return View(new SocialMediaEditVM
            {
                SocialId=existSocial.Id,
                IconClass=existSocial.Icon
                
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,SocialMediaEditVM request)
        {
            ViewBag.socials = await _socialMediaService.GetAllSelectedSocialMediaAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id is null) return BadRequest();

            var existSocial = await _socialMediaService.GetByIdAsync((int)id);

            if (existSocial is null) return NotFound();

            await _socialMediaService.EditAsync(existSocial, request);

            return RedirectToAction(nameof(Index));
        }
    }
}

