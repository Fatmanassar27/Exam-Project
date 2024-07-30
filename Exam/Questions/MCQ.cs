using Answers;
using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class MCQ : Question
    {
        public Answer [] Answers { get; set; }
        public int CorrectAnswerId { get; set; }

        public MCQ()
        {
           Answers = new Answer[3];
        }

        //create MCQ Question
        public override MCQ QType ()
        {
            HeaderOfQuestion = "MCQ Question ";

            Console.WriteLine("Enter The Body Of Question ");
            BodyOfQuestion = Console.ReadLine();

            Console.WriteLine("Enter The Mark Of Question ");
            MarkOfQuestion = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Choices Of Question  \nEnter Choice Number 1 ");
            Answers = new Answer[3];
            Answers[0] = new Answer(1, Console.ReadLine());

            Console.WriteLine("Enter Choice Number 2 ");
            Answers[1] = new Answer(2, Console.ReadLine());
            

            Console.WriteLine("Enter Choice Number 3 ");
            Answers[2] = new Answer(3, Console.ReadLine());
            

            Console.WriteLine("Enter The Right Answer Id ");
            CorrectAnswerId = int.Parse(Console.ReadLine());

            return this;
        }

        //show qu
        public override void ShowQuestion ()
        {
            Console.WriteLine( $"{HeaderOfQuestion}     Mark = {MarkOfQuestion}\n {BodyOfQuestion} ");
            
            for (int i = 0; i < Answers.Length; i++)
                Console.WriteLine( $"{i+1} - {Answers[i].AnswerText} ");

        }

    }
}
