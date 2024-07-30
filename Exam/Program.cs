using ExamsType;
using Questions;
using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.CreateExam();
            subject.PrintExam();
            subject.PrintResult();
        }
    }
}
