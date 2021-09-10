/*****************************************
 * Name:Nathan Aamodt                   **
 *Class Csc 346                         **
 *Due 4-21-2021                         **
 *****************************************
 *This file creates the node and all the**
 *variables needed as well as a         **
 *constructor and copy                  **
 ****************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNS
{
    public class Node
    {
        //Intializing the variables and the values in the Node
        public string Key { get; set; }
        public int Hash { get; set; }
        public int Probe { get; set; }
        public int Match { get; set; }
        //creates the node arguments
        public Node(string K = "", int H = -1,int P = 0, int M = 0)
        {
            Key = K;
            Hash = H;
            Probe = P;
            Match = M;
        }
        //Copy constructor for node
        public Node( Node Soul)
        {
            Key = Soul.Key;
            Hash = Soul.Hash;
            Probe = Soul.Probe;
            Match = Soul.Match;
        }
    }
}
