﻿using Aribilgi.BankApp.Web.Data.Contexts;
using Aribilgi.BankApp.Web.Data.Entities;
using Aribilgi.BankApp.Web.Data.Interfaces;
using Aribilgi.BankApp.Web.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Linq;

namespace Aribilgi.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<ApplicationUser> _userRepo;

        public HomeController(IRepository<ApplicationUser> userRepo)
        {
            _userRepo = userRepo;
        }

        public IActionResult Index()
        {
            return View(_userRepo.GetAll());
        }
    }
}
