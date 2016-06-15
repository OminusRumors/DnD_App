using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DnD
{
    public class Map
    {
        //private List<Trap> trapPosition;
        private int[,] charSpawn;
        //to keep the all objedts in the array
        private IObject[,] Storage;
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