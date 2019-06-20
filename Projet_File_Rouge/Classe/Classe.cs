using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
     abstract class Classe
     {
        private int _bonus;
        private STAT _carac;

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
        public Classe( int aTK, int dEF, int vIT, int hP, int bonus, STAT carac)
        {
            ATK = aTK;
            DEF = dEF;
            VIT = vIT;
            HP = hP;
            _bonus = bonus;
            _carac = carac;
        }

        public int GetBonus(STAT stat)
        {
            int bonus = 0;
            if (_carac == stat)
            {
                bonus = _bonus;
            }

            return (bonus + GetBonus(stat));
        }
     }
}
