using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class Question
    {

        public string? HeaderOfQuestion { get; set; }
        public string? BodyOfQuestion { get; set; }
        public int MarkOfQuestion { get; set; }
       
        public virtual Question QType()
        {
            return this;
        }

        public virtual void ShowQuestion()
        {

        }
    }
}
