using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class MoveLeftCommand : ICommand
    {
        public MoveLeftCommand(Player rcv) : base(rcv)
        {
        }


        public override void execute()
        {
            this.receiver.Move(-1, 0);
        }
    }
}
