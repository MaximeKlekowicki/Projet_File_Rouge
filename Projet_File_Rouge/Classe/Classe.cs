using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
     abstract class Classe
     {
        public string _nom;
        private int _bonus;
        private STAT _carac;

        private int _atk;

        public int ATK
        {
            get { return _atk /*+ GetBonus(STAT.ATK)*/; }
            set { _atk = value; }
        }

        private int _def;

        public int DEF
        {
            get { return _def /*+ GetBonus(STAT.DEF);*/; }
            set { _def = value; }
        }

        private int _vit;

        public int VIT
        {
            get { return _vit /*+ GetBonus(STAT.VIT);*/ ; }
            set { _vit = value; }
        }

        private int _hp;

        public int HP
        {
            get { return _hp /*+ GetBonus(STAT.PV);*/; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Points de vie < 0");
                }
                _hp = value;
            }
        }

        private List<Item> _equipement;
        public Classe(string nom,List<Item> equipement)
        {
            _nom = nom;
            ATK = 10;
            DEF = 10;
            VIT = 10;
            HP = 100;

            _equipement = new List<Item>();
        }

        /*public int GetBonus(STAT stat)
        {
            int bonus = 0;
            if (_carac == stat)
            {
                bonus = _bonus;
            }

            return (bonus + GetBonus(stat));
        }*/

        public void AjouterEquipement(Item item)
        {
            _equipement.Add(item);
        }

        public void SupprimerEquipement(Item item)
        {
            _equipement.Remove(item);
        }

        public Classe Attaquer(Classe perso)
        {
            Console.WriteLine(_nom + " inflige un gros coup");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
    }
}
