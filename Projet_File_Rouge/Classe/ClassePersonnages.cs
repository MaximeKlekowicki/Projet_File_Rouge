using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Projet_File_Rouge.Classe
{
    public enum STAT
    {
        ATK,
        DEF,
        VIT,
        PV
    }
    public class ClassePersonnage
    {
        public string _nom;
        public int _niveau;
        private readonly int _bonus;
        private readonly STAT _carac;

        #region Constructeur
        private double _atk;

        private int _xp;

        public int Xp
        {
            get { return _xp; }
            set { _xp = value; }
        }

        public double ATK
        {
            get { return _atk + GetBonus(STAT.ATK); }
            set { _atk = value; }
        }

        private int _def;

        public int DEF
        {
            get { return _def + GetBonus(STAT.DEF); }
            set { _def = value; }
        }

        private int _vit;

        public int VIT
        {
            get { return _vit + GetBonus(STAT.VIT); }
            set { _vit = value; }
        }

        private double _hp;

        public double HP
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

        private List<Item> _equipement;

        public ClassePersonnage() { }
        public ClassePersonnage(string nom, List<Item> equipement)
        {
            _nom = nom;
            ATK = 10;
            DEF = 10;
            VIT = 10;
            HP = 100;
            _xp = 0;
            _niveau = 1;

            _equipement = new List<Item>();
        }
        #endregion

        #region Fonctions
        public int GetBonus(STAT stat)
        {
            int bonus = 0;
            if (_carac == stat)
            {
                bonus = _bonus;
            }
            return 0;//(bonus + GetBonus(stat));
        }

        public void AjouterEquipement(Item item)
        {
            _equipement.Add(item);
        }

        public void SupprimerEquipement(Item item)
        {
            _equipement.Remove(item);
        }
        #endregion
    }



}
