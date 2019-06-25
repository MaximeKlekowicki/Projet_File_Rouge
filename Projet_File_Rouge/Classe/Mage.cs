using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Mage: ClassePersonnage, IAttaque
    {
        #region Constructeur
        public Mage(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 80;
            this.DEF += 30;
            this.VIT -= 20;
            this.HP += 60;
        }
        #endregion

        #region Fonctions
        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + " Lance une boule de feu");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }

        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + " Lance une boule de feu");
            perso.HP -= (ATK * 0.2 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        #endregion
    }
}
