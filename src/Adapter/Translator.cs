using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Translator : Player
    {
        private ForeignCenter foreign = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            foreign.Name = name;
        }

        public override void Attack()
        {
            foreign.ChineseAttack();
        }

        public override void Defense()
        {
            foreign.ChineseDefense();
        }
    }
}
