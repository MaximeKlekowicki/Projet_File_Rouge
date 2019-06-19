using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Items
{
    class Item
    {
        private int _bonus;

        public int Bonus
        {
            get { return _bonus; }
            private set { _bonus = value; }
        }

        private STAT _nomCarac;

        public STAT NomCarac
        {
            get { return _nomCarac; }
            private set { _nomCarac = value; }
        }

        public Item(int bonus, STAT nomCarac)
        {
            Bonus = bonus;
            NomCarac = nomCarac;
        }

        public override string ToString()
        {
            return "Bonus: " + _bonus + " Nom de carac: " + _nomCarac;
        }
    }
}
