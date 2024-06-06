using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public SliderController(ISliderService sliderService)
        {
            _sliderService = sliderService;
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
    }
}

