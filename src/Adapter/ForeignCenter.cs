using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ForeignCenter
    {
        public string Name { get; set; }

        public void ChineseAttack()
        {
            Console.WriteLine("进攻 {0}", Name);
        }

        public  void ChineseDefense()
        {
            Console.WriteLine("防守 {0} Defense", Name);
        }

    }
}
