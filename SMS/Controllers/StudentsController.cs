using Microsoft.AspNetCore.Mvc;
using SMS.Data;
using SMS.Data.Entities;
using SMS.Models;

namespace SMS.Controllers;

public class StudentsController : Controller
{
    private readonly AppDbContext _appDbContext;
    public StudentsController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public IActionResult Index()
    {
        var studentVM = _appDbContext.Students
            .Select(x => new StudentVM
            {
                Name = x.Name,
                Email = x.Email,
                Id = x.Id,
                RegNo = x.RegNo,
            })
            .ToList();

        return View(studentVM);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(StudentVM student)
    {
        if (ModelState.IsValid)
        {
            var newStudent = new Student
            {
                Name = student.Name,
                Email = student.Email,
                RegNo = Guid.NewGuid().ToString(),
            };
            //TODO: Add to Database
            _appDbContext.Students.Add(newStudent);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Students");
        }
        else
        {
            return View(student);
        }
    }
}
