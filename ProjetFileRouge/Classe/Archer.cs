using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Archer: ClassePersonnage, IAttaque
    {
        #region Constructeur

        //Constructeur
        public Archer( string nom) : base(nom)
        {
            this.ATK += 40;
            this.DEF += 30;
            this.VIT += 70;
            this.HP += 30;
        }
        #endregion

        #region Fonctions
        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Tire une fleche");
            double degats = ATK + GetBonus(STAT.ATK) - perso.DEF + perso.GetBonus(STAT.DEF);
            perso.HP -= degats;
            Console.WriteLine("Il inflige " + degats + " dégats à " + perso._nom);
            return perso;
        }
        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Tire une fleche");
            perso.HP -= (ATK * 0.3 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        #endregion

    }
}
