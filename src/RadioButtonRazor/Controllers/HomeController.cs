using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiteDB;
using RadioButtonRazor.ViewModels;
using RadioButtonRazor.Models;

namespace RadioButtonRazor.Controllers
{
    public class HomeController : Controller
    {
        private LiteDatabase _db;
        public HomeController(LiteDatabase db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<QuestionViewModel> qvmList = new List<QuestionViewModel>(); 
            foreach(var question in _db.GetCollection<Question>("questions").FindAll())
            {
                qvmList.Add(new QuestionViewModel { Question = question });
            }
            var qvm = new QuizViewModel() { QuestionViewModels = qvmList };
            return View(qvm);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

    
        public IActionResult Error()
        {
            return View();
        }
    }
}
