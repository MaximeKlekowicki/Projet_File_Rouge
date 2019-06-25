using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Orc: ClassePersonnage,IAttaque
    {
        #region Constructeur
        public Orc(string nom) : base(nom)
        {
            this.ATK += 60;
            this.DEF += 0;
            this.VIT -= 8;
            this.HP += 60;
        }
        #endregion

        #region Fonctions
        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un coup de massue");
            double degats = ATK + GetBonus(STAT.ATK) - perso.DEF + perso.GetBonus(STAT.DEF);
            perso.HP -= degats;
            Console.WriteLine("Il inflige " + degats + " dégats à " + perso._nom);
            return perso;
        }

        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un coup de massue");
            perso.HP -= (ATK * 0.3 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        #endregion

    }
}
