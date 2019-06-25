using System;
using Projet_File_Rouge.Classe;
using System.IO;
using Projet_File_Rouge.Menus;
using System.Collections.Generic;
using System.Threading;
using Projet_File_Rouge.Items;
using Projet_File_Rouge.Factories;

namespace Projet_File_Rouge
{
    class Game
    {
        static void Main(string[] args)
        {
            //Initialisation des menus
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            MenuCombat menuCombat = new MenuCombat();
            MenuActionCombat menuActionCombat = new MenuActionCombat();

            //Inisiatlisation des factory
            EnnemiFactory ennemiFactory = new EnnemiFactory();

            //Iniatialisation de la map
            Map map = new Map();

            //Initialisation des personnage jouable
            Personnage perso = new Personnage("perso", map);
            Mage jeanna = new Mage("Jeanna");
            Guerrier garrosh = new Guerrier("Garrosh");
            Archer rexxar = new Archer("Rexxar");

            jeanna.AjouterEquipement(new Item("batopn", 10, STAT.ATK));
            //List des ennemies
            List<Orc> listOrc = new List<Orc>();
            List<Gobelin> listGobelin = new List<Gobelin>();
            List<Geant> listGeant = new List<Geant>();

            for(int i = 0; i< 20; i++)
            {
                listOrc.Add((Orc)ennemiFactory.CreationEnnemi(2));
            }
             
            ConsoleKey key;


            //Initialistion des differentes options du menu principal
            List<string> menuPrincipalItems = new List<string>()
            {
                "Nouvelle Partie",
                "Charger Partie",
                "Exit"
            };

            //Initialisaiton des differentes options du menu de combat
            List<string> menuCombatItem = new List<string>()
            {
                "Attaquer",
                "Fuir",
            };

            //Initialisaiton des differentes options du menu de combat
            List<string> menuActionCombatItem = new List<string>()
            {
                "Attaque",
                "Attaque Special",
            };


            //Lancement du jeu
            while (true)
            {
                //Affichage du menu principal
                Console.Clear();
                Console.CursorVisible = false;
                string selectedMenuItem = menuPrincipal.DrawMenu(menuPrincipalItems);
                if (selectedMenuItem == "Nouvelle Partie")
                {
                    //Affichage de la map
                    do
                    {
                        Console.Clear();
                        map.DessinerMap(perso);
                        key = Console.ReadKey().Key;
                        //System de deplacement
                        switch (key)
                        {
                            case ConsoleKey.UpArrow:
                            case ConsoleKey.DownArrow:
                            case ConsoleKey.LeftArrow:
                            case ConsoleKey.RightArrow:
                                perso.DeplacementPersonnage(key);
                                //System de combat
                                if (map[perso.PosX, perso.PosY] == 'M')
                                {
                                    string selectedMenuCombatItem;
                                    do
                                    {
                                        Console.Clear();
                                        selectedMenuCombatItem = menuCombat.DrawMenu(menuCombatItem);
                                        if (selectedMenuCombatItem == "Attaquer")
                                        {
                                            do
                                            {
                                                Console.Clear();
                                                string selectedActionMenuCombat = menuActionCombat.DrawMenu(menuActionCombatItem);

                                                if (selectedActionMenuCombat == "Attaque")
                                                {
                                                    jeanna.Attaque(listOrc[1]);
                                                    Console.WriteLine(listOrc[1].HP);
                                                    Thread.Sleep(2000);
                                                }

                                            } while (jeanna.HP > 0 || listOrc[1].HP > 0);
                                        }
                                    } while (selectedMenuCombatItem != "Fuir");
                                    
                                }
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
