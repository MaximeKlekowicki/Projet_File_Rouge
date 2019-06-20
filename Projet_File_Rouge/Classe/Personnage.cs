using Projet_File_Rouge.Classe;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge
{
    public class Personnage
    {
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
            PosX = 10;
            PosY = 10;

            _equipement = new List<Item>();
        }

        public void AjouterEquipement(Item item)
        {
            _equipement.Add(item);
        }

        public void SupprimerEquipement(Item item)
        {
            _equipement.Remove(item);
        }

        public virtual int GetBonus(STAT nomCarac)
        {
            int bonus = 0;
            foreach (Item item in _equipement)
            {
                if (item.NomCarac == nomCarac)
                {
                    bonus += item.Bonus;
                }
            }

            return bonus;
        }

         public void DeplacementPersonnage(ConsoleKey key)
         {
            Map.DrawChar(this);             
            Map.EraseChar(PosX, PosY);
            switch (key) 
            {
                case ConsoleKey.UpArrow:
                    if (PosY > 0 && Map[PosX, PosY - 1] == ' ' || Map[PosX, PosY - 1] == 'M')
                        PosY--;
                    break;
                case ConsoleKey.DownArrow:
                    if (PosY < Console.WindowHeight - 1 && PosY < 19 && Map[PosX , PosY + 1] == ' ' || Map[PosX, PosY + 1] == 'M') 
                        PosY++;
                    break;
                case ConsoleKey.LeftArrow: 
                    if (PosX > 0 && Map[PosX - 1, PosY] == ' ' || Map[PosX - 1, PosY] == 'M')
                        PosX--;
                    break;
                case ConsoleKey.RightArrow: 
                    if (PosX < Console.WindowWidth - 1 && Map[PosX + 1, PosY] == ' ' || Map[PosX + 1, PosY] == 'M')
                        PosX++;
                    break;
            }
            Map.DrawChar(this);
        }
   
    }
}
