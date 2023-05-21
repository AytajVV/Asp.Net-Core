using Microsoft.EntityFrameworkCore;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
