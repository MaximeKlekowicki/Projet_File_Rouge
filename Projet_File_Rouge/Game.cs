using System;
using Projet_File_Rouge.Classe;
using System.IO;
using Projet_File_Rouge.Menus;
namespace Projet_File_Rouge
{
    class Game
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.DrawMenu();
            Map map = new Map();
            Personnage pero = new Personnage("perso", 10, 10, 10, 10, map);
            map.DessinerMap();
            pero.DeplacementPersonnage();
            Console.ReadKey(true);
        }
    }
}
