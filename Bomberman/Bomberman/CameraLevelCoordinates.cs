﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class CameraLevelCoordinates
    {
        private int xPos;
        private int yPos;
        private int[][] aeria;

        public CameraLevelCoordinates(int lvl)
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

        public int[][] getAeria()
        {
            return aeria;
        }
    }
}
