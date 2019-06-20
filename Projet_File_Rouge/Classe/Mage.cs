using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Mage: ClassePersonnage
    {
        public Mage(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 80;
            this.DEF += 30;
            this.VIT -= 20;
            this.HP += 60;
        }

        public override ClassePersonnage Attaquer(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + " Lance une boule de feu");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
        
    }
}
