using System;
using System.Collections.Generic;
using System.Text;
using Projet_File_Rouge.Classe;

namespace Projet_File_Rouge.Interface
{
    interface IAttaque
    {
        ClassePersonnage Attaque(ClassePersonnage perso);
        ClassePersonnage AttaqueSpecial(ClassePersonnage perso);

    }
}
