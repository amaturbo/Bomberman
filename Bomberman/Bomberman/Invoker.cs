using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Invoker
    {
        public void run(ICommand cmd)
        {
            cmd.execute();
        }
    }
}
