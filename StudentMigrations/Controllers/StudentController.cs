using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentMigrations.Data;
using StudentMigrations.Models;

namespace StudentMigrations.Controllers
{
	public class StudentController : Controller
	{
		private readonly ApplicationDbContext _context;

		public StudentController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			IEnumerable<Student>students=await _context.Students.ToListAsync();
			ViewBag.Students = students;
			return View();
		}
	}
}
