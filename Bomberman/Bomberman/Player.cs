using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Player
    {
        private int score;
        private int posX;
        private int posY;

        public Player(int level)
        {
            LevelStartCoordinates levelCoordinates = new LevelStartCoordinates(level);
            posX = levelCoordinates.getX();
            posY = levelCoordinates.getY();
        }

        public void Move(int x, int y)
        {
            //TODO move player 
            UpdatePos(x + posX, y + posY);
        }

        public void UpdatePos(int newX, int newY)
        {
            posX = newX;
            posY = newY;
        }

        public void PlaceBomb()
        {
            //TODO 
        }

        public int getX()
        {
            return posX;
        }

        public int getY()
        {
            return posY;
        }

        public int getScore()
        {
            return score;
        }
    }
}
