using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioButtonRazor.Models
{
    public class Choice
    {
        public String ChoiceText { get; set; }
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
