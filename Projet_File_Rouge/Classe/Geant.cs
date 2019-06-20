using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Geant: Classe
    {
        public Geant(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 100;
            this.DEF += 100;
            this.VIT -= 3;
            this.HP += 100;
        }
    }
}
