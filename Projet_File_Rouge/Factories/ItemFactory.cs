using Projet_File_Rouge.Classe;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Factories
{
    class ItemFactory
    {
        public Item CreationItem(int id)
        {
            switch(id)
            {
                case 1:
                    return new Item("hache de guerre", 20, STAT.ATK);
                case 2:
                    return new Item("epee en bois", 5, STAT.ATK);
                case 3:
                    return new Item("baton de piromancien", 30, STAT.ATK);
                case 4:
                    return new Item("arcDeChasseur", 25, STAT.ATK);
                case 5:
                    return new Item("armureDeCuire", 60, STAT.VIT);
                case 6:
                    return new Item("armurDePlate", 50, STAT.DEF);
                case 7:
                    return new Item("robeDeSorcier", 40, STAT.ATK);
                case 8:
                    return new Item("bottesLegere", 30, STAT.VIT);
                default:
                    return new Item("epee en bois", 5, STAT.ATK);

            }
        }
    }
}
