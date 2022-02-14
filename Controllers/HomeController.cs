using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public IActionResult Result(Survey survey)
        {
            if(ModelState.IsValid)   
            {
                return RedirectToAction("result");
            }
            else
            {
                return View("Index");
            }
            
            
        }
    }
}