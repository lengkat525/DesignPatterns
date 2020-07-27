using System;

namespace Adapter
{
    class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Center {0} Attack", Name);
        }

        public override void Defense()
        {
            Console.WriteLine("Center {0} Defense", Name);
        }
    }
}
