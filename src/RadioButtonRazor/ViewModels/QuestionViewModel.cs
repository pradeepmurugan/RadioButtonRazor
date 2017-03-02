using RadioButtonRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioButtonRazor.ViewModels
{
    public class QuestionViewModel
    {
        public Question Question { get; set; }
        public Choice SelectedChoice { get; set; }
    }
}
