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
        public Mage(string nom) : base(nom)
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
            double degats = ATK + GetBonus(STAT.ATK) - perso.DEF + perso.GetBonus(STAT.DEF);
            try
            {
                perso.HP -= degats;
            }
            catch (Exception)
            {
                Console.WriteLine("DEad");
            }
            Console.WriteLine("Il inflige " + degats + " dégats à " + perso._nom);
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
