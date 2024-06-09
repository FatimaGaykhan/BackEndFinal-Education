using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Setting;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly ISettingService _settingService;

        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;

        }

        public async Task<IActionResult> Index()
        {
            var settings= await _settingService.GetAllForAdminAsync();

            return View(settings);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            var setting = await _settingService.GetByIdAsync((int)id);

            if (setting is null) return NotFound();

            return View(new SettingEditVM { Key=setting.Key,Value=setting.Value});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id ,SettingEditVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id is null) return BadRequest();

            var setting = await _settingService.GetByIdAsync((int)id);

            if (setting is null) return NotFound();

            setting.Value = request.Value;

            await _settingService.EditAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

