using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Mage: Classe
    {
        public Mage(string nom, int aTK, int dEF, int vIT, int hP, Map map)
           : base(nom, aTK, dEF, vIT, hP, -10, STAT.DEF, map)
        {
        }

        public override Personnage Attaque(Personnage perso)
        {
            return base.Attaque(perso, "envoi une grosse boule de feux");
        }
    }
}
