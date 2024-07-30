using Answers;
using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class TrueFalse : Question
    {
        public bool CorrectAnswer { get; set; }

        //create True False Question
        public override TrueFalse QType()
        {
            HeaderOfQuestion = "True | False Question ";

            Console.WriteLine("Enter The Body Of Question ");
            BodyOfQuestion = Console.ReadLine();

            Console.WriteLine("Enter The Mark Of Question ");
            MarkOfQuestion = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Enter The Right Answer [1 => True   2 => False]");
            if (int.Parse(Console.ReadLine()) == 1) 
                    CorrectAnswer = true ;
            else
                    CorrectAnswer = false ;
            return this;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{HeaderOfQuestion}     Mark = {MarkOfQuestion}\n {BodyOfQuestion} ");            
            Console.WriteLine("1-True \n2-False");
        }
    }
}
