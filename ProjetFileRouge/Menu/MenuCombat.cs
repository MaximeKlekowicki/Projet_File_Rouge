﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Menus
{
    public class MenuCombat
    {
        private static int index;

        public MenuCombat() { }
        public string DrawMenu(List<string> menuItems)
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
                    index = 0;
                }
                else { index++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = menuItems.Count - 1;
                }
                else { index--; }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                switch (menuItems[index])
                {
                    case "Attaquer":
                        return menuItems[index];

                    case "Fuir":
                        return menuItems[index];
                    default:
                        break;
                }
            }

            Console.Clear();
            return "";
        }
    }
}
