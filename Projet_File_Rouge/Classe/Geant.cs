using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Geant: ClassePersonnage
    {
        public Geant(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 100;
            this.DEF += 100;
            this.VIT -= 3;
            this.HP += 100;
        }

        public override ClassePersonnage Attaquer(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Defonce un crane");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
    }
}
