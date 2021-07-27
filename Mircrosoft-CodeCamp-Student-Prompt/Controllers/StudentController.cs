using Microsoft.AspNetCore.Mvc;
using Mircrosoft_CodeCamp_Student_Prompt.Models;
using Mircrosoft_CodeCamp_Student_Prompt.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mircrosoft_CodeCamp_Student_Prompt.Controllers
{
    public class StudentController : Controller
    {

        //Displays registration view.
        public IActionResult Index()
        {
            return View();
        }


        //Displays student info view. Can be get and post
        [HttpGet]
        [HttpPost]
        public IActionResult Info(string fName, string lName)
        {
            StudentData.Students.Add(new Student(fName, lName));

            ViewBag.students = StudentData.Students;

            return View();
            //Next step is to work on the view.
        }



    }


}
