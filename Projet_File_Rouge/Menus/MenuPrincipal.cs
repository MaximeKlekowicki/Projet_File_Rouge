﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Menus
{
    public class MenuPrincipal
    {
        private static int index = 0;

        List<string> menuItems = new List<string>() {
                "Nouvelle Partie",
                "Charger Partie",
                "Exit"
            };
        public MenuPrincipal(){ }

        public void DrawMenu()
        {
            Console.CursorVisible = false;

            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine(menuItems[i]);
                }
                else
                {
                    Console.WriteLine(menuItems[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == menuItems.Count - 1)
                {
                    //index = 0; //Remove the comment to return to the topmost item in the list
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    //index = menuItem.Count - 1; //Remove the comment to return to the item in the bottom of the list
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter )
            {
                switch (menuItems[index])
                {
                    case "Nouvelle Partie":
                        Console.Clear();
                        Console.WriteLine("Test"); Console.Read();
                        break;

                    case "Charger Partie":
                        Console.Clear();
                        Console.WriteLine("Test"); Console.Read();
                        break;
                    case "Exit":
                        Environment.Exit(1);
                    break;

                    default:
                        break;
                }
            }

            Console.Clear();
        }
    }
    
}
