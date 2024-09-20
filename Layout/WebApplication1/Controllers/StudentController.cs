using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            // tạo danh sách sinh viên với 4 dữ liệu mẫu 
            listStudents = new List<Student>();
            {
                // Initialize the list of students with 4 sample data entries
                listStudents = new List<Student>()
            {
               new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT,
                   Gender = Gender.Male, IsRegular=true,
                   Address = "A1-2018", Email = "nam@g.com" },
               new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
                   Gender = Gender.Female, IsRegular=true,
                   Address = "A1-2019", Email = "tu@g.com" },
               new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
                   Gender = Gender.Male, IsRegular=false,
                   Address = "A1-2020", Email = "phong@g.com" },
               new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                   Gender = Gender.Female, IsRegular = false,
                   Address = "A1-2021", Email = "mai@g.com" }
            };
            }

        }
        public IActionResult Index()
        {
            return View(listStudents);
        }
        [HttpGet]
        public IActionResult Create()
        {

            // lấy bảng các giá trị Gender để hiển thị raido button trên form 
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            //lây danh sách các giá trị Branch để hiển thị select -option trên form
            // để hiển thị select -option trên view cần đung List <SelectListItem>
            ViewBag.Allbranches =  new List<SelectListItem>();
            {
                new SelectListItem() { Text = "IT", Value = "1" };
                new SelectListItem() { Text = "BE", Value = "2" };
                new SelectListItem() { Text = "CE", Value = "3" };
                new SelectListItem() { Text = "EE", Value = "4" };
            };
            return View();
        }
    [HttpPost]
       public IActionResult Create (Student S)
        {
            S.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(S);
            return View("Index ", listStudents);
        }
    }
    
}
