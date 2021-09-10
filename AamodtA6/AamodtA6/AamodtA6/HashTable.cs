/*****************************************
 * Name:Nathan Aamodt                   **
 *Class Csc 346                         **
 *Due 4-21-2021                         **
 *****************************************
 *This file creates a bunch of differnt **
 *functions as well as create the table **
 *and fills it after searching for the  **
 *file                                  **
 ****************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HashTableNS
{
    public class HashTable
    {
        public Node[] Table;

        //HashTable method calls in the length int and creates a table with the size 101 and call for initalize and populate the table
        public HashTable(int length)
        {
            Table = new Node[length];
            InitializeTable();
            PopulateTable();
        }
        //This is a copy constructor for the HashTable method
        public HashTable(Node[] N)
        {
            Table = N;
        }
        //This function initalizes the table with the table length
        public void InitializeTable()
        {
            for(int c = 0; c < Table.Length; c++)
            {
                Table[c] = new Node();
            }
            

        }
        //The Populate Table method calls the file and reads the nodes and places them into the correct hashes
        public void PopulateTable()
        {

            using (StreamReader sr = File.OpenText("../../../kwcsharp.txt"))
            {
                int hloc = 0;
                string input = null;
                bool atest = false;

                while((input = sr.ReadLine()) != null)
                {
                    atest = false;
                    Node Soul = new Node(input, Hash(input));
                    hloc = Soul.Hash;
                    while(!atest)
                    {
                        Soul.Probe++;
                        if(Table[hloc].Hash != -1)
                        {
                            atest = false;
                            hloc = (hloc + 5) % Table.Length;
                        }
                        else
                        {
                            atest = true;
                            Table[hloc] = Soul;
                        }
                    }

                }
            }
        }
        //The Hash method finds the position of the bite string that is called in
        public int Hash(string bite)
        {
            int hash = 0;
            byte[] bytes = Encoding.ASCII.GetBytes(bite);

            foreach (byte b in bytes)
            {
                hash += b;
            }
            hash = (hash << 8) % Table.Length;
            return hash;
        }
        //The search function uses a string to find file and prints where
        public void Search(string file)
        {
            int pos = Hash(file);
            while(Table[pos].Key != file && Table[pos].Hash != -1)
            {
                if(pos + 5 >= Table.Length)
                {
                    pos = 5 - (Table.Length - pos);
                }
                else
                {
                    pos += 5;
                }
            }

        }
    }
}
