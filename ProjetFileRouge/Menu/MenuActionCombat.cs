using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_File_Rouge.Menus
{
    class MenuActionCombat
    {
        private static int index;
        MyFile file = new MyFile("Combat.txt");
        public static List<string> banner_combat = new List<string>();
        public MenuActionCombat() { }
        public string DrawMenu(List<string> menuItems)
        {
            Console.CursorVisible = false;

            DessinerBanner();

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
                    case "Attaque":
                        return menuItems[index];

                    case "Attaque Spécial":
                        return menuItems[index];
                    default:
                        break;
                }
            }
            Console.Clear();
            return "";
        }

        public void DessinerBanner()
        {
            Console.SetCursorPosition(0, 0);

            string s = "";

            foreach (string ligne in file)
            {
                banner_combat.Add(ligne);
            }

            for (int i = 0; i < banner_combat.Count; i++)
            {
                for (int j = 0; j < banner_combat[i].Length; j++)
                {
                    s += (banner_combat[i][j]);
                }
                s += '\n';
            }
            Console.Write(s);
        }
    }
}
