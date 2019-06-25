using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Geant: ClassePersonnage, IAttaque
    {
        #region Constructuer
        public Geant(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 100;
            this.DEF += 100;
            this.VIT -= 3;
            this.HP += 100;
        }
        #endregion

        #region Fonctions
        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Defonce un crane");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }

        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Defonce un crane");
            perso.HP -= (ATK * 0.5 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        #endregion

    }
}
