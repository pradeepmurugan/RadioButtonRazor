using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioButtonRazor.Models
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }
        public IEnumerable<Choice> Choices { get; set; }
        public Question()
        { }
        public Question(Guid questionId, string questionText, IEnumerable<Choice> choices)
        {
            QuestionId = questionId;
            QuestionText = questionText;
            Choices = choices;
        }
        public Question(string questionText, IEnumerable<Choice> choices) : this(Guid.NewGuid(), questionText, choices)
        { }
    }
}
