using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P127_Pronia.DAL;
using pronia.Models;
using pronia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        { 
            HomeVM model = new HomeVM { 
            Silders= _context.Silders.ToList(),
            Plants = _context.Plants.Include(p =>p.PlantImages).ToList()
            };
            return View(model);
        }
    }
}
