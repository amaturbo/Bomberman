using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class BotFactory : IFactory
    {
        public Enemy CreateEnemy(int level, string name)
        {
            BotLevelCoordinates levelCoordinates = new BotLevelCoordinates(level);
            return new Bot(name, levelCoordinates.getX(), levelCoordinates.getY(), levelCoordinates.getReach());
        }
    }
}
