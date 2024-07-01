using Microsoft.AspNetCore.Mvc;
using PasswordManager.Models;
using System.Linq;


namespace PasswordManager.Controllers
{
    public class PasswordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PasswordController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var passwords = _context.Passwords.ToList();
            return View(passwords);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PasswordEntry entry)
        {
            if (ModelState.IsValid)
            {
                _context.Passwords.Add(entry);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entry = _context.Passwords.FirstOrDefault(e => e.Id == id);
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }

        [HttpPost]
        public IActionResult Edit(PasswordEntry entry)
        {
            if (ModelState.IsValid)
            {
                _context.Update(entry);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entry = _context.Passwords.FirstOrDefault(e => e.Id == id);
            if (entry != null)
            {
                _context.Passwords.Remove(entry);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
