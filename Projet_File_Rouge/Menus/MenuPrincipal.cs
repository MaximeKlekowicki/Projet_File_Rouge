using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Menus
{
    public class MenuPrincipal
    {
        private static int index = 0;

        public MenuPrincipal(){ }

        public string drawMenu(List<string> menuItems)
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
            else if (ckey.Key == ConsoleKey.Enter )
            {
                switch (menuItems[index])
                {
                    case "Nouvelle Partie":
                        return menuItems[index];

                    case "Charger Partie":
                        return menuItems[index];

                    case "Exit":
                        Environment.Exit(0);
                    break;

                    default:
                        break;
                }
            }
            Console.Clear();
            return "";
        }
    }
    
}
