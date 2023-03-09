using FluentValidation.Results;
using GerenciadorSquad.Models;
using GerenciadorSquad.Validator;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorSquad.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
            }

            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Index(UserViewModel user)
        {
            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
                return View("Index", user);
            }

            // Processa o login
            return RedirectToAction("Index", "Home");
        }
    }
}
