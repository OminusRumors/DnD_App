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
        private Point charSpawn;
        private IObject[,] storage;

        private Dictionary<Trap, Point> trapPosList;

        public Map()
        {

        }

        public Map(IObject[,] storage)
        {
            this.storage = storage;
        }

        public Dictionary<Trap, Point> TrapPosList
        {
            get { return trapPosList; }
            set { trapPosList = value; }
        }

        internal void SpawnLoc(int spawnx, int spawny)
        {
            charSpawn = new Point(spawnx, spawny);
        }
    }
}