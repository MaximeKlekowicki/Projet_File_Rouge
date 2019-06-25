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

        //Factory de creation des ennemies
        public ClassePersonnage CreationEnnemi(int id)
        {
            switch(id)
            {
                case 1:
                    return new Gobelin("Gobelin");
                case 2:
                    return new Orc("Orc");
                case 3:
                    return new Geant("Geant");
                default:
                    return new Geant("Geant");
                    
            }
        }
    }
}
