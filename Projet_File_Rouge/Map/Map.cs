using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projet_File_Rouge
{
    public class Map
    {
        StreamReader sr = new StreamReader("map.txt");
        MyFile file = new MyFile("map.txt");
        int nbLigne = 20;
        public static string[] Maps = new string [20];

        public int Length { get { return Maps.Length; } set { } }


        public char this [int i, int j]
        {
            get
            {
                return Maps[i][j];
            }

            set { }
        }

        public Map ()
        {
            for(int i = 0; i<nbLigne; i++)
            {
                Maps[i] = file[i];
            }
        }

        public void DessinerMap()
        {
            for (int i = 0; i < nbLigne; i++)
            {
               Console.WriteLine(file[i]);
            }
        }
    }
}
