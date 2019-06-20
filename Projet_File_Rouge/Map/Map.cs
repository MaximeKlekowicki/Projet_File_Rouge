using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Projet_File_Rouge
{
    public class Map
    {
        MyFile File;
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
            File = new MyFile("map.txt");
            foreach (string line in File)
            {
                Maps.Add(line);
            }
        }

        public void DessinerMap(Personnage perso)
        {
            string s ="";

            for (int i = 0; i < Maps.Count; i++)
            {
                for (int j = 0; j < Maps[i].Length; j++)
                {
                    s += (Maps[i][j]);
                }
                s += '\n';
            }
            Console.Write(s + '\n');
            DrawChar(perso);
            
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
