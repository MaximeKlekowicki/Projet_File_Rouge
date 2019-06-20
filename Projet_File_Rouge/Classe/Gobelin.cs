using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Gobelin:Classe
    {
        public Gobelin(string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 30;
            this.DEF += 30;
            this.VIT -= 10;
            this.HP += 50;
        }
    }
}
