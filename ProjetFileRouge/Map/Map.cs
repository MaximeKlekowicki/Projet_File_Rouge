using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Projet_File_Rouge
{
    public class Map
    {
        #region Attributs
        MyFile File;
        public static List<string> Maps;

        public int Length { get { return Maps.Count; } set { } }

        public char this[int i, int j]
        {
            get
            {
                return Maps[j][i];
            }

            set { }
        }

        public string this[int i]
        {
            get
            {
                return Maps[i];
            }

            set { }
        }
        #endregion

        #region Constructeur
        public Map()
        {
            Maps = new List<string>();
            File = new MyFile("map.txt");
            foreach (string line in File)
            {
                Maps.Add(line);
            }
        }
        #endregion

        #region Fonctions
        public void DessinerMap(Personnage perso)
        {
            string s = "";

            int xCenter = Console.WindowWidth / 2;
            int yCenter = Console.WindowHeight / 2;
            int xleft;
            int ytop;

            lock (perso)
            {
                xleft = perso.PosX - xCenter;
                ytop = perso.PosY - yCenter;
            }

            lock (Maps)
            {
                xCenter = xleft < 0 ? xCenter + xleft : xCenter;
                yCenter = ytop < 0 ? yCenter + ytop : yCenter;
                xleft = xleft + Console.WindowWidth > Maps[0].Length ? Maps[0].Length - Console.WindowWidth : xleft;
                xleft = xleft < 0 ? 0 : xleft;
                ytop = ytop + Console.WindowHeight > Maps.Count ? Maps.Count - Console.WindowHeight : ytop;
                ytop = ytop < 0 ? 0 : ytop;
            }

            for (int i = ytop; i < ytop + Console.WindowHeight; i++)
            {
                for (int j = xleft; j < xleft + Console.WindowWidth; j++)
                {
                    s += this[j, i];
                }
            }

            Console.Write(s);
            Console.SetCursorPosition(xCenter, yCenter);
            Console.Write("@");
        }

        public void EraseChar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
        #endregion
    }
}
