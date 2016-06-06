using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DnD_App
{
    public class Map
    {
        //private List<Trap> trapPosition;
        private int[,] charSpawn;
        private Dictionary<Trap, Point> trapPosList;

        public Map()
        {

        }

        public Dictionary<Trap, Point> TrapPosList
        {
            get { return trapPosList; }
            set { trapPosList = value; }
        }
    }
}