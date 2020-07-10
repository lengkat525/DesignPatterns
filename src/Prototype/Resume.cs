using System;

namespace Prototype
{
    class Resume
    {
        private string _name;
        private string _sex;
        private string _age;
        private string _timeArea;
        private string _company;

        public Resume(string name)
        {
            _name = name;
        }

        public void SetPersonInfo(string sex, string age)
        {
            _sex = sex;
            _age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            _timeArea = timeArea;
            _company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _sex, _age);
            Console.WriteLine("{0} {1}", _timeArea, _company);
        }
    }
}
