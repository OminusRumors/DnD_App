using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DnD_App
{
    public class Map
    {
        private Dictionary<Character, Point> charPosition;
        //private List<Trap> trapPosition;
        private int[,] charSpawn;

        public Dictionary<Character, Point> CharPosition
        {
            get { return charPosition; }
            set { charPosition = value; }
        }

        public Map()
        {

        }

        public Map(Dictionary<Character,Point> startPosition)
        {
            this.charPosition = startPosition;
        }

        public Character GetCharacter(Point point)
        {
            Character c = charPosition.FirstOrDefault(t => t.Value == point).Key;
            return c;
        }

        public Point GetPoint(Character character)
        {
            Point point = charPosition.FirstOrDefault(t => t.Key == character).Value;
            return point;
        }
    }
}