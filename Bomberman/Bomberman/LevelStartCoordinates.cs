using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class LevelStartCoordinates
    {
        private int xPos;
        private int yPos;

        public LevelStartCoordinates(int lvl)
        {
            //TODO get level info from database
        }

        public int getX()
        {
            return xPos;
        }

        public int getY()
        {
            return yPos;
        }
    }
}
