using DnD_App;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Game
    {
        Dictionary<Character, Point> charList;
        Map map;
        Dice dice;

        public Game(Dictionary<Character, Point> charPosList)
        {
            map = new Map();
            dice = new Dice();
            charList = charPosList;
        }

        public Dictionary<Character, Point> CharList
        {
            get { return charList; }
            set { charList = value; }
        }

        public Character GetCharacter(Point point)
        {
            Character c = charList.FirstOrDefault(t => t.Value == point).Key;
            return c;
        }

        public Point GetPoint(Character character)
        {
            Point point = charList.FirstOrDefault(t => t.Key == character).Value;
            return point;
        }

        public Point UpdateCharPosition(Character character, Point newPosition)
        {
            Character c = charList.First(t => t.Key == character).Key;
            charList[c] = newPosition;
            return newPosition;
        }

        public bool Attack(Character attacker, Character defender, int diceSides)
        {
            //check if within weapon range
            if (Math.Sqrt((GetPoint(attacker).X - GetPoint(defender).X) ^ 2 +
                (GetPoint(attacker).Y - GetPoint(defender).Y) ^ 2) <= attacker.CharWeapon.WeapRange)
            {
                int tempDice = dice.Roll(diceSides);
                //if defender didnt evade
                if (tempDice >= diceSides / 2)
                {
                    tempDice = dice.Roll(10);
                    //if critical hit
                    if (tempDice <= attacker.CharWeapon.WeapCriticalChance)
                    {
                        defender.CharHealth -= attacker.GetDamage() * 2;
                        return true;
                    }
                    else
                    {
                        defender.CharHealth -= attacker.GetDamage();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
