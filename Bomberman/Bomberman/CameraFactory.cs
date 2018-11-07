using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class CameraFactory : IFactory
    {
        public Enemy CreateEnemy(int level, string name)
        {
            CameraLevelCoordinates levelCoordinates = new CameraLevelCoordinates(level);
            return new Camera(name, levelCoordinates.getX(), levelCoordinates.getY(), levelCoordinates.getAeria());
        }
    }
}
