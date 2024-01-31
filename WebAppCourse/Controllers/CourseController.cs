using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourse.Models;

namespace WebAppCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course{CId=1,CName="Animation",CFee=25000,Technology="Grapics",CStartDate=new DateTime(day:01,month:04,year:2021), CEndDate=new DateTime(day:15,month:07,year:2021)},
            new Course{CId=2,CName="Data Science and Machine Learning",CFee=40000,Technology="Python",CStartDate=new DateTime(day:01,month:01,year:2022), CEndDate=new DateTime(day:20,month:06,year:2022)},
            new Course{CId=3,CName="Web Development",CFee=30000,Technology="HTML, CSS & JS",CStartDate=new DateTime(day:05,month:04,year:2023), CEndDate=new DateTime(day:05,month:05,year:2023)},
            new Course{CId=4,CName="IOT",CFee=350000,Technology="IOT Hardware",CStartDate=new DateTime(day:10,month:07,year:2023), CEndDate=new DateTime(day:10,month:10,year:2023)}
        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        public ActionResult Create(Course c)
        {
            if (ModelState.IsValid)
            {
                courses.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }
    }
}