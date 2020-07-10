using System;

namespace Prototype
{
    class PrototypeDemo
    {
        static void Main(string[] args)
        {
            //NewMethod();
            Resume leng = new Resume("Leng");
            leng.SetPersonInfo("woman", "26");
            leng.SetWorkExperience("2017-2020", "chr");
            Resume leng2 = leng;
            Resume leng3 = leng;

            leng.Display();
            leng2.Display();
            leng3.Display();
            Console.Read();
        }

        private static void NewMethod()
        {
            Resume leng = new Resume("Leng");
            leng.SetPersonInfo("woman", "26");
            leng.SetWorkExperience("2017-2020", "chr");
            leng.Display();

            Resume leng2 = new Resume("Leng");
            leng2.SetPersonInfo("woman", "26");
            leng2.SetWorkExperience("2017-2020", "chr");
            leng2.Display();

            Resume leng3 = new Resume("Leng");
            leng3.SetPersonInfo("woman", "26");
            leng3.SetWorkExperience("2017-2020", "chr");
            leng3.Display();

            Console.Read();
        }
    }
}
