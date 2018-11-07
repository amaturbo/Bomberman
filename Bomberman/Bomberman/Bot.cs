using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Bot : Enemy
    {
        private int reachDistance;

        public Bot(string name, int x, int y, int reach) : base(name, x, y)
        {
            reachDistance = reach;
            CalculateAeria();
        }

        public void Move(int x, int y)
        {
            //TODO move bot 
            UpdatePos(x + posX, y + posY);
        }

        public void UpdatePos(int newX, int newY)
        {
            posX = newX;
            posY = newY; 
        }

        public void CalculateAeria()
        {
            for (int i = 0; i < reachDistance; i++)
            {
                KillAeria[0][0 + (i * 4)] = posX - (i + 1);
                KillAeria[1][0 + (i * 4)] = posY;
                KillAeria[0][1 + (i * 4)] = posX + (i + 1);
                KillAeria[1][1 + (i * 4)] = posY;
                KillAeria[0][2 + (i * 4)] = posY + (i + 1);
                KillAeria[1][2 + (i * 4)] = posX;
                KillAeria[0][3 + (i * 4)] = posY - (i + 1);
                KillAeria[1][3 + (i * 4)] = posX;
            }
        }
    }
}
