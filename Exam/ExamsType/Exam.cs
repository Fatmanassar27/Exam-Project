using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace ExamsType
{
    internal class Exam
    {
        public int Result { get; set; }
        public int FullMark { get; set; }
        public  Stopwatch TimeOfExam { get; set; }
        public  int NumberOfQuestion { get; set; }
        public Subject ExamSubject { get; set; }

        public Exam()
        {
            TimeOfExam = Stopwatch.StartNew();
        }
        public virtual void ShowExam()
        {
            Console.WriteLine("EXAM");
        }

        public virtual Exam CreateExam()
        {
            return this;
        }
        public virtual void ResultOfExam()
        {
            Console.WriteLine("EXAM");
        }
    }
}
