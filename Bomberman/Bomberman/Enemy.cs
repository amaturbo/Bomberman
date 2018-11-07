using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Enemy
    {
        private string name;
        protected int posX;
        protected int posY;
        protected int[][] KillAeria = new int[2][];

        public Enemy(string name, int x, int y, int[][] aeria)
        {
            this.name = name;
            posX = x;
            posY = y;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < aeria[0].Length; j++)
                    KillAeria[i][j] = aeria[i][j];
        }

        public Enemy(string name, int x, int y)
        {
            this.name = name;
            posX = x;
            posY = y;
        }

        public void Kill()
        {
            //TODO: kill player code here
        }

        public void Check()
        {
            //TODO: check if the player is in the surveilance aeria
            
        }

        public void Die()
        {
            //TODO when enemy is killed
        }
    }
}
