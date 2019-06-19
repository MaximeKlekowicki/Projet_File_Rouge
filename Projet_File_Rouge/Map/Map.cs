using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projet_File_Rouge
{
    public class Map
    {
        MyFile file;
        public static List<string> Maps;

        public int Length { get { return Maps.Count; } set { } }

        public char this [int i, int j]
        {
            get
            {
                return Maps[j][i];
            }

            set { }
        }

        public Map ()
        {
            Maps = new List<string>();
            file = new MyFile("map.txt");
            foreach (string line in file)
            {
                Maps.Add(line);
            }
        }

        public void DessinerMap()
        {
            for (int i = 0; i < Maps.Count; i++)
            {
                for (int j = 0; j < Maps[i].Length; j++)
                {
                    Console.Write(Maps[i][j]);
                }
                Console.Write('\n');
            }
        }

        public void DrawChar(Personnage perso)
        {
            Console.SetCursorPosition(perso.PosX, perso.PosY);
            Console.Write("@");
        }

        public void EraseChar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
    }
}
