using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Guards {0} Attack", Name);
        }

        public override void Defense()
        {
            Console.WriteLine("Guards {0} Defense", Name);
        }
    }
}
