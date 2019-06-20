using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Guerrier: Classe
    {
        public Guerrier(string nom, int aTK, int dEF, int vIT, int hP, Map map)
             : base(aTK, dEF, vIT, hP, 50, STAT.ATK)
        {
        }

       
    }
}
