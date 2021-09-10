/********************************************************************
*** NAME : Nathan Aamodt                                          ***
*** CLASS : CSC 346                                               ***
*** ASSIGNMENT : AamodtA3 - Assign 4                              ***
*** DUE DATE : March  22nd 2021                                   ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** This File contains the character class that sets up default values as well as a space for values to be input.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterNS

{
   public class Character
    {
        public string Name { get; set; }
        public Global.RaceType Race { get; set; }
        public short Health { get; set; }



        public Character(string name = "Geralt", Global.RaceType race = Global.RaceType.WITCHER, short health = 200)
        {
            Name = name;
            Race = race;
            Health = health;
        }   
        
        public Character(Character one)
        {
            Name = one.Name;
            Race = one.Race;
            Health = one.Health;
        }
    }
}
