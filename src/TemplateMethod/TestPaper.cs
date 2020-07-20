using System;

namespace TemplateMethod
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("A. Math1 B. Math2 C. Math3 D. Math4");
            Console.WriteLine("Answer " + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("A. Chinese1 B. Chinese2 C. Chinese3 D.Chinese4");
            Console.WriteLine("Answer " + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("A. English1 B. English2 C. English3 D. English4");
            Console.WriteLine("Answer " + Answer3());
        }
        protected virtual string Answer1()
        {
            return "";
        }
        protected virtual string Answer2()
        {
            return "";
        }
        protected virtual string Answer3()
        {
            return "";
        }
    }

    class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "B";
        }
        protected override string Answer2()
        {
            return "B";
        }
        protected override string Answer3()
        {
            return "B";
        }
        //public new void TestQuestion1()
        //{
        //    base.TestQuestion1();
        //    Console.WriteLine("Answer: B");
        //}

        //public new void TestQuestion2()
        //{
        //    base.TestQuestion2();
        //    Console.WriteLine("Answer: B");
        //}

        //public new void TestQuestion3()
        //{
        //    base.TestQuestion3();
        //    Console.WriteLine("Answer: B");
        //}
    }

    class TestPaperB: TestPaper
    {
        protected override string Answer1()
        {
            return "C";
        }
        protected override string Answer2()
        {
            return "C";
        }
        protected override string Answer3()
        {
            return "C";
        }
        //public new void TestQuestion1()
        //{
        //    base.TestQuestion1();
        //    Console.WriteLine("Answer: c");
        //}

        //public new void TestQuestion2()
        //{
        //    base.TestQuestion2();
        //    Console.WriteLine("Answer: c");
        //}

        //public new void TestQuestion3()
        //{
        //    base.TestQuestion3();
        //    Console.WriteLine("Answer: c");
        //}
    }


}
