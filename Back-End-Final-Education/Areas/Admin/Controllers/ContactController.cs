using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Helpers.Extensions;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var contact = await _contactService.GetAllForAdminAsync();

            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var contact = await _contactService.GetByIdAsync((int)id);

            if (contact is null) return NotFound();



            await _contactService.DeleteAsync(contact);

            return RedirectToAction(nameof(Index));
        }
    }
}

