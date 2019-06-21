using Projet_File_Rouge.Interface;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Guerrier: ClassePersonnage, IAttaque
    {
        public Guerrier(string nom, List<Item> equipement): base(nom, equipement)
        {
            this.ATK += 50;
            this.DEF += 50;
            this.VIT -= 5;
            this.HP += 70;
        }

        public ClassePersonnage Attaque(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un gros coup");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }

        public ClassePersonnage AttaqueSpecial(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un gros coup");
            perso.HP -= (ATK*0.1 - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
    }
}
