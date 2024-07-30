using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsType
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }

        //create exam
        public Exam CreateExam ()
        {
            //ExamOfSubject.TimeOfExam = new System.Diagnostics.Stopwatch ();
            Console.WriteLine("Enter The Type Of Exam [1 => Final Exam  OR 2 => Practical Exam]");
            int r = int.Parse ( Console.ReadLine() );
            if ( r == 1 )
            {
                ExamOfSubject = new FinalExam();
                ExamOfSubject.CreateExam();
            }
            else if ( r == 2 )
            {
                ExamOfSubject = new PracticalExam();
                ExamOfSubject.CreateExam();
            }
            return this.ExamOfSubject;
        }

        //Show Exam
        public void PrintExam ()
        {
            ExamOfSubject?.ShowExam();
        }
        public void PrintResult ()
        {
            ExamOfSubject?.ResultOfExam();
        }



        //
    }
}
