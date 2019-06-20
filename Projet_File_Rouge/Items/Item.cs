using System;
using System.Collections.Generic;
using System.Text;
using Projet_File_Rouge.Classe;

namespace Projet_File_Rouge.Items
{
    public class Item
    {

        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

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

        public Item(string nom, int bonus, STAT nomCarac)
        {
            _nom = nom;
            Bonus = bonus;
            NomCarac = nomCarac;
        }

        public override string ToString()
        {
            return "Nom: " + _nom + "Bonus: " + _bonus + " Nom de carac: " + _nomCarac;
        }
    }
}
