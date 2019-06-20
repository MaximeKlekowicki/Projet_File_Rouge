using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Orc: ClassePersonnage
    {
        public Orc(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 60;
            this.DEF += 60;
            this.VIT -= 8;
            this.HP += 60;
        }

        public override ClassePersonnage Attaquer(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un coup de massue");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
    }
}
