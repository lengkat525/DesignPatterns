using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Pursuit : GiveGift
    {
        readonly Girl _mm;

        public Pursuit(Girl mm)
        {
            _mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(_mm.Name + " Pursuit Dolls");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_mm.Name + " Pursuit Flowers");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(_mm.Name + " Pursuit Chocolate");
        }
    }
}
