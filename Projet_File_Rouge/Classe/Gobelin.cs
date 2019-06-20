using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Gobelin: ClassePersonnage
    {
        public Gobelin(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 30;
            this.DEF += 30;
            this.VIT -= 10;
            this.HP += 50;
        }

        public override ClassePersonnage Attaquer(ClassePersonnage perso)
        {
            Console.WriteLine(_nom + "Donne un coup legerement enervant");
            perso.HP -= (ATK - perso.DEF);
            Console.WriteLine("Il inflige " + ATK + " dégats à " + perso._nom);
            return perso;
        }
    }
}
