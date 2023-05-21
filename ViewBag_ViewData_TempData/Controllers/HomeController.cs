using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ViewBag_ViewData_TempData.DAL;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //ViewData 
            //var p = new Product
            //{
            //    Id = 1,
            //    Name = "Lorem",
            //    Price = 100

            //};
            //ViewData["ProductName"] = p.Name;


            //ViewBag
            //ViewBag.Name = "Hello";


            //TempData
            //TempData["Age"] = 20;

            //return RedirectToAction("About");
            //DbContextOptions options = new DbContextOptions();
            // AppDbContext context = new AppDbContext(); burda new-lanir basqa yerde new-lanir dependency injection
            //IoContainer


            //List<Student> students = _context.Students.ToList(); //sql-den gelen datalari liste yigir
            //Student student = _context.Students.Find(1);     //key isteyir bu zaman id-si 1 olani getirir
            //Student student1 = _context.Students.FirstOrDefault(s => s.Id==2);  
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
