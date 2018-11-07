using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class MoveDownCommand : ICommand
    {
        public MoveDownCommand(Player rcv) : base(rcv)
        {
        }

       
        public override void execute()
        {
            this.receiver.Move(0, -1);
        }
    }
}
