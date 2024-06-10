using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End_Final_Education.Models;
using Back_End_Final_Education.Services;
using Back_End_Final_Education.Services.Interfaces;
using Back_End_Final_Education.ViewModels.Contact;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Back_End_Final_Education.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly UserManager<AppUser> _userManager;

        public ContactController(IContactService contactService,
                                 UserManager<AppUser> userManager)
        {
            _contactService = contactService;
            _userManager = userManager;
        }
        public async Task< IActionResult> Index()
        {
            AppUser user = new();

            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);

            }

            ContactVM model = new()
            {
                Email = user.Email
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(ContactVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index));
            }

            //if (request.Username is null)
            //{
            //    ModelState.AddModelError("Username", "Input cannot be empty");
            //    //return RedirectToAction(nameof(Index));
            //}

            //if (request.Email is null)
            //{
            //    ModelState.AddModelError("Email", "Input cannot be empty");
            //    //return RedirectToAction(nameof(Index));
            //}

            //if (request.Subject is null)
            //{
            //    ModelState.AddModelError("Subject", "Input cannot be empty");
            //    //return RedirectToAction(nameof(Index));
            //}

            //if (request.Message is null)
            //{
            //    ModelState.AddModelError("Message", "Input cannot be empty");
            //    //return RedirectToAction(nameof(Index));
            //}

            await _contactService.CreateAsync(new Models.Contact { Message=request.Message,Email=request.Email,Subject=request.Subject,Username=request.Username,CreatedDate=DateTime.Now,SoftDeleted=false});

            return RedirectToAction(nameof(Index));
        }
    }
}

