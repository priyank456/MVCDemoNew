using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Students.ToList());
        }

        public IActionResult AddReply(int studentId)
        {
            var comment = new Comment();
            comment.StudentID = studentId;
            return PartialView("_AddReply", comment);
        }

        [HttpPost]
        public IActionResult AddReply(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
    }
}