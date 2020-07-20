using System;

namespace TemplateMethod
{
    class TemplateMethodDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("studentA");
            TestPaper studentA = new TestPaperA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();
            studentA.TestQuestion3();

            Console.WriteLine("\nstudentB");
            TestPaper studentB = new TestPaperB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();
            studentB.TestQuestion3();

            Console.Read();
        }
    }
}
