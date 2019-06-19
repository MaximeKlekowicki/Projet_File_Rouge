using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Guerrier: Classe
    {
        public Guerrier(string nom, int aTK, int dEF, int vIT, int hP, Map map)
             : base(nom, aTK, dEF, vIT, hP, 50, STAT.ATK, map)
        {
        }

        public override Personnage Attaque(Personnage perso)
        {
            return base.Attaque(perso, "donne une grosse baffe dans la face");
        }
    }
}
