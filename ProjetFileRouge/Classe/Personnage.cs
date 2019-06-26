using Projet_File_Rouge.Classe;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge
{
    public class Personnage
    {
        #region Constructeur
        public string Nom;


        private int _PosX;

        public int PosX
        {
            get { return _PosX; }
            set { _PosX = value; }
        }

        private int _Posy;

        public int PosY
        {
            get { return _Posy; }
            set { _Posy = value; }
        }


        private Map _map;

        public Map Map
        {
            get { return _map; }
            set { _map = value; }
        }

        private List<Item> _equipement;

        public Personnage(string nom, Map map)
        {
            Nom = nom;
            _map = map;
            PosX = 990;
            PosY = 990;

            _equipement = new List<Item>();
        }
        #endregion

        #region Fonctions
        public void DeplacementPersonnage(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (PosY > 0 && Map[PosX, PosY - 1] != '#')
                        PosY--;
                    break;
                case ConsoleKey.DownArrow:
                    if (PosY < Map.Length && Map[PosX, PosY + 1] != '#')
                        PosY++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (PosX > 0 && Map[PosX - 1, PosY] != '#')
                        PosX--;
                    break;
                case ConsoleKey.RightArrow:
                    if (PosX < Map[0].Length && Map[PosX + 1, PosY] != '#')
                        PosX++;
                    break;
            }
        }
        #endregion
    }
}
