using Projet_File_Rouge.Classe;
using Projet_File_Rouge.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Factories
{
    public class EnnemiFactory: ClassePersonnage
    {

        public EnnemiFactory() { }
        //Initialisation des items des ennemie
        List<Item> itemOrc = new List<Item>();
        List<Item> itemGobelin = new List<Item>();
        List<Item> itemGeant = new List<Item>();

        //Factory de creation des ennemies
        public ClassePersonnage CreationEnnemi(int id)
        {
            switch(id)
            {
                case 1:
                    return new Gobelin("Gobelin", itemGobelin);
                case 2:
                    return new Orc("Orc", itemOrc);
                case 3:
                    return new Geant("Geant", itemGeant);
                default:
                    return new Geant("Geant", itemGeant);
                    
            }
        }
    }
}
