using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Guerrier: ClassePersonnage, IAttaque
    {
        #region Constructeur
        public Guerrier(string nom) : base(nom)
        {
            this.ATK += 50;
            this.DEF += 50;
            this.VIT -= 5;
            this.HP += 70;
        }
        #endregion

        #region Fonctions
        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un gros coup");
            double degats = ATK + GetBonus(STAT.ATK) - perso.DEF + perso.GetBonus(STAT.DEF);
            perso.HP -= degats;
            Console.WriteLine("Il inflige " + degats + " dégats à " + perso._nom);
            return perso;
        }

        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un gros coup");
            perso.HP -= (ATK * 0.1 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        #endregion

    }
}
