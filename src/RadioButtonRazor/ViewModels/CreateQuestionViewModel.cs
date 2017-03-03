using Microsoft.AspNetCore.Mvc;
using RadioButtonRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioButtonRazor.ViewModels
{
    public class CreateQuestionViewModel
    {
        public string QuestionText { get; set; }
        public Choice Choice1 { get; set; }
        public Choice Choice2 { get; set; }
        public Choice Choice3 { get; set; }
        public Choice Choice4 { get; set; }
        
        public Question Question {
            get
            {
                return new Question(QuestionText, new Choice[] { Choice1, Choice2, Choice3, Choice4 });
            }
        }
       
    }
}
