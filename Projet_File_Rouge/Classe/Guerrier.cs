using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Guerrier: Classe
    {
        public Guerrier(string nom, List<Item> equipement): base(nom, equipement)
        {
            this.ATK += 50;
            this.DEF += 50;
            this.VIT -= 5;
            this.HP += 70;
        }

       
    }
}
