using ExamsType;
using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Answers;

namespace ExamsType
{
    internal class FinalExam : Exam
    {
        int[] answerslist { get; set; }
        int[] TFanswerslist { get; set; }
        int [] TFUserAnswers { get; set; }
        public MCQ[] MCQquestions { get; set; }
        public TrueFalse[] TFquestions { get; set; }
        int[] McqUserAnswers { get; set; }
        public FinalExam()
        {
            TFanswerslist = new int[100];
            TFUserAnswers = new int[100];
            McqUserAnswers = new int[100];
            TFUserAnswers = new int[100];
            answerslist = new int[100];
            MCQquestions = new MCQ[100];
            TFquestions = new TrueFalse[100];
        }

        //creat final exam
        public override FinalExam CreateExam()
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("Enter The Time Of Exam : [30 min to 180 min]");
            int.Parse (Console.ReadLine());

            Console.WriteLine("Enter The Number Of The Question ");
            int cnt = int.Parse(Console.ReadLine());
            Console.Clear();

            while (cnt > 0)
            {
                  MCQquestions = new MCQ [cnt];
                  Console.WriteLine("Enter The Type Of Question : [1 => MCQ Exam  OR 2 => True|False Exam]");
                  int y = int.Parse(Console.ReadLine());
                  Console.Clear();
                  if (y == 1)
                  {
                      MCQquestions[i] = new MCQ(); 
                      MCQquestions[i] = MCQquestions[i].QType();
                      answerslist[i] = MCQquestions[i].CorrectAnswerId;
                      i++;
                  }
                  else if (y == 2)
                  {
                    TFquestions[j] = new TrueFalse ();
                    TFquestions[j] = TFquestions[j].QType();
                    if (TFquestions[j].CorrectAnswer)
                        TFanswerslist[j] = 1;
                    else
                        TFanswerslist[j] = 2;

                        j++;
                  }
                  cnt--;
                  Console.Clear ();
            }
                  return this;

        }

        //show final exam
        public override void ShowExam ()
        {

            for (int i = 0; i < MCQquestions.Length ; i++)
            {
                if (MCQquestions[i] is not null)
                {
                    MCQquestions[i]?.ShowQuestion() ;
                    Console.Write("Enter Your Answer Id : ");
                    McqUserAnswers[i] = int.Parse(Console.ReadLine());
                }
                else 
                    break;
            }
  
            for (int i = 0; i < TFquestions.Length ; i++)
            {
                if (TFquestions[i] is not null)
                {
                    TFquestions[i].ShowQuestion();
                    Console.Write("Enter Your Answer : [1=> true   2=> false]\n");
                    int A = int.Parse(Console.ReadLine());
                    if (A == 1)
                          TFUserAnswers[i] = 1;
                    else
                          TFUserAnswers[i] = 2;

                }
                else break;
            }
            Console.Clear ();   
        }

        //Result 
        public override void ResultOfExam()
        {
            for(int i = 0;i < McqUserAnswers.Length ; i++)
            {
                if (McqUserAnswers[i] != 0)
                {
                    Console.WriteLine($"Question {i + 1} is : {MCQquestions[i].BodyOfQuestion}");
                    Console.WriteLine($"Your Answer is : {MCQquestions[i].Answers[McqUserAnswers[i]-1].AnswerText}");
                    Console.WriteLine($"Correct Answer is : {MCQquestions[i].Answers[answerslist[i]-1].AnswerText}");
                    if (McqUserAnswers[i] == answerslist[i])
                    {
                        Result += MCQquestions[i].MarkOfQuestion;
                    }
                    FullMark += MCQquestions[i].MarkOfQuestion;
                }
            }


            for (int i = 0; i < TFUserAnswers.Length; i++)
            {
                if( TFUserAnswers[i] != 0)
                {
                    Console.WriteLine($"Question {i + 1} is : {TFquestions[i].BodyOfQuestion}");
                    Console.WriteLine($"Correct Answer is : {TFquestions[i].CorrectAnswer} ");
                    if (TFUserAnswers[i]== 1) 
                          Console.WriteLine($"Your Answer is : True");
                    else
                          Console.WriteLine($"Your Answer is : False");
                    if (TFUserAnswers[i] == TFanswerslist[i])
                        Result += TFquestions[i].MarkOfQuestion;
                       
                    FullMark += TFquestions[i].MarkOfQuestion;
                }
            }
            Console.WriteLine($"Your Result is {Result} Out Of {FullMark}");
            Console.WriteLine($"Time is {TimeOfExam}");
            Console.WriteLine("Thank You");
        }

    }
}
