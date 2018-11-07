using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    abstract class ICommand
    {
        protected Player receiver = null;

        public ICommand(Player rcv)
        {
            this.setReceiver(rcv);
        }

        public abstract void execute();


        public void setReceiver(Player receiver)
        {
            this.receiver = receiver;
        }

        public Player getReceiver()
        {
            return receiver;
        }
    }
}
