﻿using Microsoft.AspNetCore.Mvc;
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
            return View();
            //Controler para chamar a View Login
        }
    }
}
