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
        Dictionary<Character, Point> npcList;
        Dictionary<Trap, Point> trapList;
        ServerDelegates svDelegates;
        Map map;
        Dice dice;
        int playerCounter;

        public Game()
        {

        }

        public Game(Dictionary<Character, Point> charPosList)
        {
            svDelegates = new ServerDelegates();
            map = new Map();
            dice = new Dice();
            charList = charPosList;
            playerCounter = 0;
        }

        public Game(Dictionary<Character,Point> charPosList, Dictionary<Character,Point> npcPosList, Dictionary<Trap,Point> trapPosList)
        {
            svDelegates = new ServerDelegates();
            map = new Map();
            dice = new Dice();
            charList = charPosList;
            trapList = trapPosList;
            npcList = npcPosList;
        }

        public Character NextPlayer()
        {
            Character chara;
            if (playerCounter < charList.Count)
            {
                chara = charList.ElementAt(playerCounter).Key;
                playerCounter++;
                return chara;
            }
            else
            {
                playerCounter = 0;
                return charList.ElementAt(playerCounter).Key;
            }
        }

        public Dictionary<Trap,Point> TrapList
        {
            get { return trapList; }
            set { trapList = value; }
        }

        public Dictionary<Character, Point> CharList
        {
            get { return charList; }
            set { charList = value; }
        }

        public void AddCharacter(Character character)
        {
            charList.Add(character, new Point());
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

        public bool DropItem(Character chara, Item item)
        {
            if (chara.Inventory.Contains(item))
            {
                chara.Inventory.Remove(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Updates a character's position.
        /// No checks are done (will be implemented later).
        /// </summary>
        /// <param name="character">The moving character.</param>
        /// <param name="newPosition">The new position of the character.</param>
        /// <returns>The new position.</returns>
        public Point UpdateCharPosition(Character character, Point newPosition)
        {
            Character c = charList.First(t => t.Key == character).Key;
            charList[c] = newPosition;
            return newPosition;
        }

        /// <summary>
        /// Implements an attack between 2 characters.
        /// Checks the range of weapons, evading chance and critical hits.
        /// </summary>
        /// <param name="attacker">The attacking character.</param>
        /// <param name="defender">The defending character.</param>
        /// <param name="diceSides">The sides of the dice.</param>
        /// <returns>True if attack succeeds, false otherwise.</returns>
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
                    //else normal hit
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
