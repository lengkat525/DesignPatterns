using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Forwards {0} Attack", Name);
        }

        public override void Defense()
        {
            Console.WriteLine("Forwards {0} Defense", Name);
        }
    }
}
