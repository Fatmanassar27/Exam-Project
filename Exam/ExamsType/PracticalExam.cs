using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsType
{
    internal class PracticalExam : Exam
    {
        int[] McqUserAnswers { get; set; }
        public MCQ [] Questions { get; set; }
        int[] answerslist { get; set; }

        public PracticalExam()
        {
            McqUserAnswers = new int[100];
            Questions   = new MCQ[100];
            answerslist = new int[100];
        }

        //create practical exam
        public override PracticalExam CreateExam()
        {
            int i = 0;
            Console.WriteLine("Enter The Time Of Exam : [30 min to 180 min]");
            int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("Enter The Number Of The Question ");
            int cnt = int.Parse(Console.ReadLine());
            Console.Clear();

            while (cnt > 0)
            {
                Questions[i] = new MCQ();
                Questions[i] = Questions[i].QType();
                answerslist[i] = Questions[i].CorrectAnswerId;
                i++;
                cnt--;
                Console.Clear() ;
            } 
            return this;
        }

        //show MCQ exam
        public override void ShowExam()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i] != null)
                {
                   Questions[i].ShowQuestion();
                   Console.Write("Enter Your Answer Id : ");
                   McqUserAnswers[i] = int.Parse(Console.ReadLine());
                }
                else
                    break;
            }
            Console.Clear() ;
        }

        //Result
        public override void ResultOfExam()
        {
            for (int i = 0; i < McqUserAnswers.Length; i++)
            {
                if (McqUserAnswers[i] != 0)
                {
                    Console.WriteLine($"Question {i + 1} is : {Questions[i].BodyOfQuestion}");
                    Console.WriteLine($"Your Answer is : {Questions[i].Answers[McqUserAnswers[i] - 1].AnswerText}");
                    Console.WriteLine($"Correct Answer is : {Questions[i].Answers[answerslist[i]-1].AnswerText}");
                    if (McqUserAnswers[i] == answerslist[i])
                    {
                        Result += Questions[i].MarkOfQuestion;
                    }
                    FullMark += Questions[i].MarkOfQuestion;
                }
            }
            Console.WriteLine($"Your Grade is {Result} Out Of {FullMark}");
            Console.WriteLine($"Time is {TimeOfExam}");
        }
    }
}
