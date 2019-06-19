using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
     abstract class Classe: Personnage
    {
        private int _bonus;
        private STAT _carac;

        public Classe(string nom, int aTK, int dEF, int vIT, int hP, int bonus, STAT carac, Map map) :
            base(nom, aTK, dEF, vIT, hP, map)
        {
            _bonus = bonus;
            _carac = carac;
        }

        protected override int GetBonus(STAT stat)
        {
            int bonus = 0;
            if (_carac == stat)
            {
                bonus = _bonus;
            }

            return (bonus + base.GetBonus(stat));
        }

        protected Personnage Attaque(Personnage perso, string textAtk)
        {
            int degas = (ATK - perso.DEF);
            if (degas < 0)
            {
                degas = 0;
            }
            Console.WriteLine(Nom + " " + textAtk);
            Console.WriteLine("Il inflige " + degas + " sur " + perso.Nom);
            perso.HP -= degas;
            return perso;
        }

        public virtual Personnage Attaque(Personnage perso)
        {
            return Attaque(perso, "attaque");
        }
    }
}
