using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Gobelin: ClassePersonnage, IAttaque
    {
        #region Constructeur
        public Gobelin(string nom) : base(nom)
        {
            this.ATK += 30;
            this.DEF += 30;
            this.VIT -= 10;
            this.HP += 50;
        }
        #endregion

        #region Fonctions
        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un coup legerement enervant");
            double degats = ATK + GetBonus(STAT.ATK) - perso.DEF + perso.GetBonus(STAT.DEF);
            perso.HP -= degats;
            Console.WriteLine("Il inflige " + degats + " dégats à " + perso._nom);
            return perso;
        }

        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un coup encore plus enervant");
            perso.HP -= (ATK * 0.2 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        #endregion

    }
}
