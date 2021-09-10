/********************************************************************
*** NAME : Nathan Aamodt                                          ***
*** CLASS : CSC 346                                               ***
*** ASSIGNMENT : AamodtA3 - Assign 3                              ***
*** DUE DATE : Febuary 26th 2021                                  ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : This Assignment is creating 2 players in a game ***
*** one using defult constructor then anouther using values passed***
*** in from the Program.cs file, this allows 2 differnt types of  ***
*** players/characters in this game.                              ***
********************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroNS
{
/********************************************************************
*** METHOD Class Global()                                         ***
*********************************************************************
*** DESCRIPTION : This Sets up the defined enumerators.           ***
*** INPUT ARGS : NONE                                             ***
*** OUTPUT ARGS: NONE, Sets global values for other classes to use***
*** IN/OUT ARGS : NONE                                            ***
*** RETURN : NONE Defing Class                                    ***
********************************************************************/
    public static class Global
    {
      public  enum RaceType {DRAGON,WITCHER,VAMPIRE };
      public  enum WeaponType {AXE,MACE,SWORD,SPELL};
    }
}
