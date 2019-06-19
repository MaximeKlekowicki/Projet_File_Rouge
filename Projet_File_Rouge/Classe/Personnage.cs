using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge
{
    public enum STAT
    {
        ATK,
        DEF,
        VIT,
        PV
    }

    public class Personnage
    {
        public string Nom;
        private int _atk;

        public int ATK
        {
            get { return _atk + GetBonus(STAT.ATK); }
            private set { _atk = value; }
        }

        private int _def;

        public int DEF
        {
            get { return _def + GetBonus(STAT.DEF); }
            private set { _def = value; }
        }

        private int _vit;

        public int VIT
        {
            get { return _vit + GetBonus(STAT.VIT); }
            private set { _vit = value; }
        }

        private int _hp;

        public int HP
        {
            get { return _hp + GetBonus(STAT.PV); }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Points de vie < 0");
                }
                _hp = value;
            }
        }

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

        public Personnage(string nom, int aTK, int dEF, int vIT, int hP, Map map)
        {
            Nom = nom;
            ATK = aTK;
            DEF = dEF;
            VIT = vIT;
            HP = hP;
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

        public override string ToString()
        {
            string txt = Nom + " atk: " + ATK + " def: " + DEF + " vit: " + VIT + " hp: " + VIT + "\r\n";
            foreach (Item item in _equipement)
            {
                txt += item + "\r\n";
            }
            return txt;
        }

         public void DeplacementPersonnage()
         {
             Map.DrawChar(this);

             ConsoleKey key = ConsoleKey.Enter; // Valeur initiale
             do
             {
                 if (Console.KeyAvailable)
                 {
                     key = Console.ReadKey(true).Key;
                    Map.EraseChar(PosX, PosY);
                     switch (key) 
                     {
                         case ConsoleKey.UpArrow:
                             if (PosY > 0 && Map[PosX, PosY - 1] == ' ')
                                 PosY--;
                             break;
                         case ConsoleKey.DownArrow:
                             if (PosY < Console.WindowHeight - 1 && PosY < 19 && Map[PosX , PosY + 1] == ' ') 
                                 PosY++;
                             break;
                         case ConsoleKey.LeftArrow: 
                             if (PosX > 0 && Map[PosX - 1, PosY] == ' ')
                                 PosX--;
                             break;
                         case ConsoleKey.RightArrow: 
                             if (PosX < Console.WindowWidth - 1 && Map[PosX + 1, PosY] == ' ')
                                 PosX++;
                             break;
                     }

                     Map.DrawChar(this); 
                 }
             } while (key != ConsoleKey.Escape); 
         }   
    }
}
