using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioButtonRazor.ViewModels
{
    public class QuizViewModel
    {
        public IEnumerable<QuestionViewModel> QuestionViewModels { get; set; }
    }
}
