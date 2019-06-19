using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Archer: Classe
    {
        public Archer(string nom, int aTK, int dEF, int vIT, int hP, Map map)
                : base( aTK, dEF, vIT, hP, 15, STAT.VIT)
        {
        }

       
    }
}
