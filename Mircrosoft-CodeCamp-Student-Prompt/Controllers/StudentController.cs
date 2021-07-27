using Microsoft.AspNetCore.Mvc;
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


        //Displays student info view. Can be get and Set
        [HttpGet]
        [HttpPost]
        public IActionResult Info()
        {
            return View();
        }



    }


}
