using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
            var result = studentRepository.GetAll();
            return View(result);
            //return Json(result);
        }

        public IActionResult Create()
        {
            //return Json(new { message = "Create action called" });
            return BadRequest();
            //return RedirectToAction("Index");
            //return File("path/to/file.txt", "text/plain");
            //return View();
        }
        public IActionResult Delete()
        {
            return Content("This is studentRepository delete page");
        }
        public IActionResult Edit()
        {
            return Content("This is edit page");
        }
    }
}
