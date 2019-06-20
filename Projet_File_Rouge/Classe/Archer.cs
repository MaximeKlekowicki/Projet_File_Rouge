﻿using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Classe
{
    class Archer: Classe
    {
        public Archer( string nom, List<Item> equipement) : base(nom, equipement)
        {
            this.ATK += 40;
            this.DEF += 30;
            this.VIT += 70;
            this.HP += 30;
        }

       
    }
}
