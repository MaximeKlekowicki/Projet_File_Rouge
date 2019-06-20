﻿using System;
using Projet_File_Rouge.Classe;
using System.IO;
using Projet_File_Rouge.Menus;
using System.Collections.Generic;
using System.Threading;

namespace Projet_File_Rouge
{
    class Game
    {
        static void Main(string[] args)
        {

            MenuPrincipal menuPrincipal = new MenuPrincipal();

            Map map = new Map();
            Personnage perso = new Personnage("perso", map);

            ConsoleKey key;



            List<string> menuItems = new List<string>()
            {
                "Nouvelle Partie",
                "Charger Partie",
                "Exit"
            };


            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                string selectedMenuItem = menuPrincipal.drawMenu(menuItems);
                if (selectedMenuItem == "Nouvelle Partie")
                {

                    do
                    {
                        Console.Clear();
                        map.DessinerMap(perso);
                        key = Console.ReadKey().Key;
                        switch (key)
                        {
                            case ConsoleKey.UpArrow:
                            case ConsoleKey.DownArrow:
                            case ConsoleKey.LeftArrow:
                            case ConsoleKey.RightArrow:
                                perso.deplacementPersonnage(key);
                                break;
                            default:
                                break;
                        }
                        Thread.Sleep(10);
                    } while (key != ConsoleKey.Escape);
                }
            }
        }
    }
}
