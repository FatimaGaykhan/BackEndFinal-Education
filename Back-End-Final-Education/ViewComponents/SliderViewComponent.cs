using System;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Back_End_Final_Education.ViewComponents
{
	public class SliderViewComponent:ViewComponent
	{
        private readonly ISliderService _sliderService;

        public SliderViewComponent(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliderDatas = new SliderVMVC
            {
                Sliders = await _sliderService.GetAllAsync()
            };

            return await Task.FromResult(View(sliderDatas));
        }


    }
    public class SliderVMVC
    {
        public IEnumerable<Slider> Sliders { get; set; }

    }
}

