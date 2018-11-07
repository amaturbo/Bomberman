using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class MoveUpCommand : ICommand
    {
        public MoveUpCommand(Player rcv) : base(rcv)
        {
        }


        public override void execute()
        {
            this.receiver.Move(0, 1);
        }
    }
}
