using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Informations;
using Back_End_Final_Education.ViewModels.Slider;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InformationController : Controller
    {
        private readonly IInformationService _infoService;

        public InformationController(IInformationService infoService)
        {
            _infoService = infoService;

        }
        public async Task<IActionResult> Index()
        {
            var infos = await _infoService.GetAllForAdminAsync();
          
            return View(infos);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            InformationDetailVM information = await _infoService.DetailAsync((int)id);

            if (information is null) return NotFound();


            return View(information);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.informations = await _infoService.GetAllSelectedAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InformationCreateVM request)
        {
            ViewBag.informations = await _infoService.GetAllSelectedAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            Information information = new()
            {
                Title=request.Title,
                Description = request.Description,
                IconId = request.IconId,

            };


            await _infoService.CreateAsync(information);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {

            if (id is null) return BadRequest();

            var information = await _infoService.GetByIdAsync((int)id);

            if (information is null) return NotFound();

            await _infoService.DeleteAsync(information);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.informations = await _infoService.GetAllSelectedAsync();

           
            if (id is null) return BadRequest();

            var existInfo = await _infoService.GetByIdWithAllDatasAsync((int)id);

            if (existInfo is null) return NotFound();


            return View(new InformationEditVM
            {
                Description = existInfo.Description,
                IconId = existInfo.IconId,
                Title=existInfo.Title
               
            });


        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, InformationEditVM request)
        {
            ViewBag.informations = await _infoService.GetAllSelectedAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }


            if (id is null) return BadRequest();

            if (await _infoService.ExistExceptByIdAsync((int)id, request.Title))
            {
                ModelState.AddModelError("Title", "This castegory name already exist");
                return View();
            }

            var existInfo = await _infoService.GetByIdWithAllDatasAsync((int)id);

            if (existInfo is null) return NotFound();

            await _infoService.EditAsync(existInfo, request);

            return RedirectToAction(nameof(Index));


        }
    }
}

