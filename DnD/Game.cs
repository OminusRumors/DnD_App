using DnD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Game
    {
        Dictionary<Character, Point> charList;
        Dictionary<Character, Point> npcList;
        Dictionary<Trap, Point> trapList;
        Character currentPlayer;
        Map map;
        Dice dice;
        int playerCounter;

        public Game()
        {

        }

        public Game(Dictionary<Character, Point> charPosList)
        {
            map = new Map();
            dice = new Dice();
            charList = charPosList;
            playerCounter = 0;
        }

        public Game(Dictionary<Character, Point> charPosList, Dictionary<Trap, Point> trapPosList)
        {
            map = new Map();
            dice = new Dice();
            charList = charPosList;
            trapList = trapPosList;
        }

        public void AddWeapon(Weapon weapon)
        {
            Character c = charList.FirstOrDefault(t => t.Key.CharName == weapon.).Key;
            c.CharWeapon = weapon;
        }

        public Character NextPlayer()
        {
            if (playerCounter < charList.Count)
            {
                currentPlayer = charList.ElementAt(playerCounter).Key;
                playerCounter++;
                return currentPlayer;
            }
            else
            {
                playerCounter = 0;
                currentPlayer = charList.ElementAt(playerCounter).Key;
                return currentPlayer;
            }
        }

        public Character CurrentCharacter
        {
            get { return currentPlayer; }
        }

        public Dictionary<Trap, Point> TrapList
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

        public void AddCharacter(Character character, Point point)
        {
            charList.Add(character, point);
        }

        /// <summary>
        /// Gets the closest player's character from the point.
        /// </summary>
        /// <param name="point">The point player clicked.</param>
        /// <returns>The closest player from the point.</returns>
        public Character GetCharacter(Point point)
        {
            Character c = charList.FirstOrDefault(t => t.Value == point).Key;
            int tempDistance;
            int closerDistance = 0;
            foreach (Character chara in charList.Keys)
            {
                //find the distance between the point and the character
                tempDistance = Convert.ToInt32(Math.Sqrt((point.X - charList[chara].X) ^ 2 + (point.Y - charList[chara].Y) ^ 2));
                if (tempDistance < closerDistance)
                {
                    c = chara;
                    closerDistance = tempDistance;
                }
            }
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
        /// Gets a character from its name.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <returns>A character instance.</returns>
        public Character GetCharacter(string name)
        {
            Character c = charList.FirstOrDefault(t => t.Key.CharName == name).Key;
            return c;
        }

        /// <summary>
        /// Updates a character's position.
        /// No checks are done.
        /// </summary>
        /// <param name="character">The moving character.</param>
        /// <param name="newPosition">The new position of the character.</param>
        /// <returns>The new position.</returns>
        public void UpdateCharPosition(Character character, Point newPosition)
        {
            Character c = charList.First(t => t.Key == character).Key;
            charList[c] = newPosition;
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
