using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class PlaceBombCommand : ICommand
    {
        public PlaceBombCommand(Player rcv) : base(rcv)
        {
        }


        public override void execute()
        {
            this.receiver.PlaceBomb();
        }
    }
}
