/********************************************************************
*** NAME : Nathan Aamodt                                          ***
*** CLASS : CSC 346                                               ***
*** ASSIGNMENT : AamodtA3 - Assign 4                              ***
*** DUE DATE : March  22nd 2021                                   ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*********************************************************************
*** DESCRIPTION : This Assignment is creating 2 players in a game ***
*** one using defult constructor then anouther using values passed***
*** in from the Program.cs file, this allows 2 differnt types of  ***
*** players/characters in this game.                              ***
********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;


namespace CharacterNS

{

    public class Hero : Character
    {
        /********************************************************************
        *** METHOD Getters and setters                                    ***
        *********************************************************************
        *** DESCRIPTION : This grabs values for the data types.           ***
        *** INPUT ARGS : NONE                                             ***
        *** OUTPUT ARGS: Sets/gets values for types                       ***
        *** IN/OUT ARGS : NONE                                            ***
        *** RETURN : NONE                                                 ***
        ********************************************************************/
        public short Protection { get; set; }
        public Global.WeaponType Weapon { get; set; }
        /********************************************************************
        *** METHOD Class Hero()                                           ***
        *********************************************************************
        *** DESCRIPTION : This creates a default character in the game.   ***
        *** INPUT ARGS : NONE                                             ***
        *** OUTPUT ARGS: NONE, Sets global values for other classes.      ***
        *** IN/OUT ARGS : NONE                                            ***
        *** RETURN : NONE Defing Class                                    ***
        ********************************************************************/

        public Hero():base()
        {

        }
        /*************************************************************************************************************************
        *** METHOD Class Hero(string ,Global.RaceType ,int ,int ,Global.WeaponType )                                           ***
        **************************************************************************************************************************
        *** DESCRIPTION : This creates a character in the game as set by the input varaibles in program.cs                     ***
        *** INPUT ARGS :  name, race,health,protection, weapon                                                                 ***
        *** OUTPUT ARGS: NONE, just allows other classes to use data                                                           ***
        *** IN/OUT ARGS : NONE                                                                                                 ***
        *** RETURN : NONE                                                                                                      ***
        **************************************************************************************************************************/
        public Hero(string name = "Geralt", Global.RaceType race = Global.RaceType.DWARF, short health=200,short protection = 50, Global.WeaponType weapon = Global.WeaponType.AXE): base (name,race, health)
        {
           Name = name;
           Race = race;
           Health = health;
           Protection = protection;
           Weapon = weapon;
        }

        public Hero(Hero ein)
        {
            Name = ein.Name;
            Race = ein.Race;
            Health = ein.Health;
            Protection = ein.Protection;
            Weapon = ein.Weapon;
        }


    }
}
