using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RadioButtonRazor.Models
{
    public class Choice
    {
        private Func<IActionResult> create;

        public string ChoiceText { get; set; }
        public bool IsCorrectChoice { get; set; } = true;
        public Choice()
        {
        }
        public Choice(string choiceText, bool isCorrectChoice = true)
        {
            ChoiceText = choiceText;
            IsCorrectChoice = isCorrectChoice;
        }
    }
}
