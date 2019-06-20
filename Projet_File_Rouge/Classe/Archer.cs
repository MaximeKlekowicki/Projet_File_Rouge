using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Archer: ClassePersonnage
    {
        public Archer( string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 40;
            this.DEF += 30;
            this.VIT += 70;
            this.HP += 30;
        }

        public override ClassePersonnage Attaquer(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Tire une fleche");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
    }
}
